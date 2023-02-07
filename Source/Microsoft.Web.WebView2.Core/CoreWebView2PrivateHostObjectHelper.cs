using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2PrivateHostObjectHelper
{
    private class RawHelper : ICoreWebView2PrivateHostObjectHelper, ICoreWebView2PrivateHostObjectHelper2
    {
        private const int DISP_E_MEMBERNOTFOUND = -2147352573;

        private const int DISP_E_TYPEMISMATCH = -2147352571;

        private const int WIN_BOOL_TRUE = 1;

        private const int WIN_BOOL_FALSE = 0;

        private const int S_OK = 0;

        private MethodInfo GetMethodInfo(Type type, string methodName, int? parameterCount)
        {
            if (!type.IsClass || type.IsCOMObject)
            {
                throw new COMException(null, -2147352571);
            }
            MemberInfo[] member = type.GetMember(methodName);
            if (member.Length == 0)
            {
                throw new COMException(null, -2147352573);
            }
            MemberInfo[] array = member;
            foreach (MemberInfo memberInfo in array)
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                {
                    MethodInfo methodInfo = (MethodInfo)memberInfo;
                    if (!parameterCount.HasValue || methodInfo.GetParameters().Length == parameterCount.Value)
                    {
                        return methodInfo;
                    }
                }
            }
            return null;
        }

        public int IsMethodMember(ref object rawObject, string memberName)
        {
            if (!(GetMethodInfo(rawObject.GetType(), memberName, null) == null))
            {
                return 1;
            }
            return 0;
        }

        public int IsAsyncMethod(ref object rawObject, string methodName, int parameterCount)
        {
            MethodInfo methodInfo = GetMethodInfo(rawObject.GetType(), methodName, parameterCount);
            if (methodInfo == null)
            {
                throw new COMException(null, -2147352571);
            }
            if (AwaitableReflection.FromAwaitableType(methodInfo.ReturnType) != null)
            {
                return 1;
            }
            return 0;
        }

        public void SetAsyncMethodContinuation(ref object rawObject, string methodName, int parameterCount, ref object methodResult, ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
        {
            if (GetMethodInfo(rawObject.GetType(), methodName, parameterCount) == null)
            {
                throw new COMException(null, -2147352571);
            }
            AwaitableReflection ar = AwaitableReflection.FromAwaitableType(methodResult.GetType());
            if (ar == null)
            {
                throw new COMException(null, -2147352571);
            }
            object awaiter = ar.InvokeGetAwaiter(methodResult);
            Action action = delegate
            {
                object obj = null;
                int num = 0;
                try
                {
                    obj = ar.InvokeGetResult(awaiter);
                }
                catch (Exception e)
                {
                    num = Marshal.GetHRForException(e);
                }
                ICoreWebView2PrivateHostObjectAsyncMethodContinuation coreWebView2PrivateHostObjectAsyncMethodContinuation = continuation;
                int errorCode = num;
                object result = obj;
                coreWebView2PrivateHostObjectAsyncMethodContinuation.Invoke(errorCode, ref result);
            };
            if (ar.InvokeIsCompleted(awaiter))
            {
                action();
            }
            else
            {
                ar.InvokeOnCompleted(awaiter, action);
            }
        }
    }

    private class AwaitableReflection
    {
        private Type _awaitable;

        private MethodInfo _getAwaiter;

        private Type _awaiter;

        private PropertyInfo _isCompleted;

        private MethodInfo _onCompleted;

        private MethodInfo _getResult;

        public static AwaitableReflection FromAwaitableType(Type type)
        {
            MethodInfo method = type.GetMethod("GetAwaiter");
            if (method == null || method.GetParameters().Length != 0)
            {
                return null;
            }
            Type returnType = method.ReturnType;
            PropertyInfo property = returnType.GetProperty("IsCompleted");
            if (property == null || !property.CanRead || property.PropertyType != typeof(bool))
            {
                return null;
            }
            MethodInfo method2 = returnType.GetMethod("OnCompleted");
            if (method2 == null)
            {
                return null;
            }
            ParameterInfo[] parameters = method2.GetParameters();
            if (parameters.Length != 1 || parameters[0].ParameterType != typeof(Action))
            {
                return null;
            }
            MethodInfo method3 = returnType.GetMethod("GetResult");
            if (method3 == null || method3.GetParameters().Length != 0)
            {
                return null;
            }
            return new AwaitableReflection(type, method, returnType, property, method2, method3);
        }

        private AwaitableReflection(Type awaitable, MethodInfo getAwaiter, Type awaiter, PropertyInfo isCompleted, MethodInfo onCompleted, MethodInfo getResult)
        {
            _awaitable = awaitable;
            _getAwaiter = getAwaiter;
            _awaiter = awaiter;
            _isCompleted = isCompleted;
            _onCompleted = onCompleted;
            _getResult = getResult;
        }

        public object InvokeGetAwaiter(object awaitable)
        {
            if (awaitable.GetType() != _awaitable)
            {
                throw new InvalidOperationException($"Invoking {_getAwaiter.Name} on an object of type {awaitable.GetType()} when an awaitable object of type {_awaitable} was expected.");
            }
            return _getAwaiter.Invoke(awaitable, Array.Empty<object>());
        }

        public bool InvokeIsCompleted(object awaiter)
        {
            if (awaiter.GetType() != _awaiter)
            {
                throw new InvalidOperationException($"Invoking {_isCompleted.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {_awaiter} was expected.");
            }
            return (bool)_isCompleted.GetValue(awaiter);
        }

        public void InvokeOnCompleted(object awaiter, Action continuation)
        {
            if (awaiter.GetType() != _awaiter)
            {
                throw new InvalidOperationException($"Invoking {_onCompleted.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {_awaiter} was expected.");
            }
            _onCompleted.Invoke(awaiter, new object[1] { continuation });
        }

        public object InvokeGetResult(object awaiter)
        {
            if (awaiter.GetType() != _awaiter)
            {
                throw new InvalidOperationException($"Invoking {_getResult.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {_awaiter} was expected.");
            }
            return _getResult.Invoke(awaiter, Array.Empty<object>());
        }
    }

    internal ICoreWebView2PrivateHostObjectHelper _nativeICoreWebView2PrivateHostObjectHelperValue;

    internal ICoreWebView2PrivateHostObjectHelper2 _nativeICoreWebView2PrivateHostObjectHelper2Value;

    internal object _rawNative;

    internal ICoreWebView2PrivateHostObjectHelper _nativeICoreWebView2PrivateHostObjectHelper
    {
        get
        {
            if (_nativeICoreWebView2PrivateHostObjectHelperValue == null)
            {
                try
                {
                    _nativeICoreWebView2PrivateHostObjectHelperValue = (ICoreWebView2PrivateHostObjectHelper)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2PrivateHostObjectHelperValue;
        }
        set
        {
            _nativeICoreWebView2PrivateHostObjectHelperValue = value;
        }
    }

    internal ICoreWebView2PrivateHostObjectHelper2 _nativeICoreWebView2PrivateHostObjectHelper2
    {
        get
        {
            if (_nativeICoreWebView2PrivateHostObjectHelper2Value == null)
            {
                try
                {
                    _nativeICoreWebView2PrivateHostObjectHelper2Value = (ICoreWebView2PrivateHostObjectHelper2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2PrivateHostObjectHelper2Value;
        }
        set
        {
            _nativeICoreWebView2PrivateHostObjectHelper2Value = value;
        }
    }

    internal CoreWebView2PrivateHostObjectHelper()
    {
        _rawNative = new RawHelper();
    }

    internal CoreWebView2PrivateHostObjectHelper(object rawCoreWebView2PrivateHostObjectHelper)
    {
        _rawNative = rawCoreWebView2PrivateHostObjectHelper;
    }

    public int IsMethodMember(object rawObject, string memberName)
    {
        try
        {
            ICoreWebView2PrivateHostObjectHelper nativeICoreWebView2PrivateHostObjectHelper = _nativeICoreWebView2PrivateHostObjectHelper;
            object @object = rawObject;
            return nativeICoreWebView2PrivateHostObjectHelper.IsMethodMember(ref @object, memberName);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
            }
            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
            }
            throw ex2;
        }
    }

    public int IsAsyncMethod(object rawObject, string methodName, int parameterCount)
    {
        try
        {
            ICoreWebView2PrivateHostObjectHelper2 nativeICoreWebView2PrivateHostObjectHelper = _nativeICoreWebView2PrivateHostObjectHelper2;
            object @object = rawObject;
            return nativeICoreWebView2PrivateHostObjectHelper.IsAsyncMethod(ref @object, methodName, parameterCount);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
            }
            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
            }
            throw ex2;
        }
    }

    public void SetAsyncMethodContinuation(object rawObject, string methodName, int parameterCount, object methodResult, CoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
    {
        try
        {
            ICoreWebView2PrivateHostObjectHelper2 nativeICoreWebView2PrivateHostObjectHelper = _nativeICoreWebView2PrivateHostObjectHelper2;
            object @object = rawObject;
            object methodResult2 = methodResult;
            nativeICoreWebView2PrivateHostObjectHelper.SetAsyncMethodContinuation(ref @object, methodName, parameterCount, ref methodResult2, continuation._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
            }
            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
            }
            throw ex2;
        }
    }
}
