//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
[SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
internal unsafe struct cef_drag_data_t
{
    internal cef_base_ref_counted_t _base;
    internal IntPtr _clone;
    internal IntPtr _is_read_only;
    internal IntPtr _is_link;
    internal IntPtr _is_fragment;
    internal IntPtr _is_file;
    internal IntPtr _get_link_url;
    internal IntPtr _get_link_title;
    internal IntPtr _get_link_metadata;
    internal IntPtr _get_fragment_text;
    internal IntPtr _get_fragment_html;
    internal IntPtr _get_fragment_base_url;
    internal IntPtr _get_file_name;
    internal IntPtr _get_file_contents;
    internal IntPtr _get_file_names;
    internal IntPtr _set_link_url;
    internal IntPtr _set_link_title;
    internal IntPtr _set_link_metadata;
    internal IntPtr _set_fragment_text;
    internal IntPtr _set_fragment_html;
    internal IntPtr _set_fragment_base_url;
    internal IntPtr _reset_file_contents;
    internal IntPtr _add_file;
    internal IntPtr _clear_filenames;
    internal IntPtr _get_image;
    internal IntPtr _get_image_hotspot;
    internal IntPtr _has_image;
    
    // Create
    [DllImport(libcef.LibraryName, EntryPoint = "cef_drag_data_create", CallingConvention = libcef.CEF_CALL)]
    public static extern cef_drag_data_t* create();
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void add_ref_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int release_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int has_one_ref_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int has_at_least_one_ref_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_drag_data_t* clone_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int is_read_only_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int is_link_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int is_fragment_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int is_file_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_link_url_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_link_title_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_link_metadata_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_fragment_text_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_fragment_html_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_fragment_base_url_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_string_userfree* get_file_name_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate UIntPtr get_file_contents_delegate(cef_drag_data_t* self, cef_stream_writer_t* writer);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int get_file_names_delegate(cef_drag_data_t* self, cef_string_list* names);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_link_url_delegate(cef_drag_data_t* self, cef_string_t* url);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_link_title_delegate(cef_drag_data_t* self, cef_string_t* title);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_link_metadata_delegate(cef_drag_data_t* self, cef_string_t* data);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_fragment_text_delegate(cef_drag_data_t* self, cef_string_t* text);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_fragment_html_delegate(cef_drag_data_t* self, cef_string_t* html);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void set_fragment_base_url_delegate(cef_drag_data_t* self, cef_string_t* base_url);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void reset_file_contents_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void add_file_delegate(cef_drag_data_t* self, cef_string_t* path, cef_string_t* display_name);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void clear_filenames_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_image_t* get_image_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate cef_point_t get_image_hotspot_delegate(cef_drag_data_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int has_image_delegate(cef_drag_data_t* self);
    
    // AddRef
    private static IntPtr _p0;
    private static add_ref_delegate _d0;
    
    public static void add_ref(cef_drag_data_t* self)
    {
        add_ref_delegate d;
        var p = self->_base._add_ref;
        if (p == _p0) { d = _d0; }
        else
        {
            d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
            if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
        }
        d(self);
    }
    
    // Release
    private static IntPtr _p1;
    private static release_delegate _d1;
    
    public static int release(cef_drag_data_t* self)
    {
        release_delegate d;
        var p = self->_base._release;
        if (p == _p1) { d = _d1; }
        else
        {
            d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
            if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
        }
        return d(self);
    }
    
    // HasOneRef
    private static IntPtr _p2;
    private static has_one_ref_delegate _d2;
    
    public static int has_one_ref(cef_drag_data_t* self)
    {
        has_one_ref_delegate d;
        var p = self->_base._has_one_ref;
        if (p == _p2) { d = _d2; }
        else
        {
            d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
            if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
        }
        return d(self);
    }
    
    // HasAtLeastOneRef
    private static IntPtr _p3;
    private static has_at_least_one_ref_delegate _d3;
    
    public static int has_at_least_one_ref(cef_drag_data_t* self)
    {
        has_at_least_one_ref_delegate d;
        var p = self->_base._has_at_least_one_ref;
        if (p == _p3) { d = _d3; }
        else
        {
            d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
            if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
        }
        return d(self);
    }
    
    // Clone
    private static IntPtr _p4;
    private static clone_delegate _d4;
    
    public static cef_drag_data_t* clone(cef_drag_data_t* self)
    {
        clone_delegate d;
        var p = self->_clone;
        if (p == _p4) { d = _d4; }
        else
        {
            d = (clone_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(clone_delegate));
            if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
        }
        return d(self);
    }
    
    // IsReadOnly
    private static IntPtr _p5;
    private static is_read_only_delegate _d5;
    
    public static int is_read_only(cef_drag_data_t* self)
    {
        is_read_only_delegate d;
        var p = self->_is_read_only;
        if (p == _p5) { d = _d5; }
        else
        {
            d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
            if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
        }
        return d(self);
    }
    
    // IsLink
    private static IntPtr _p6;
    private static is_link_delegate _d6;
    
    public static int is_link(cef_drag_data_t* self)
    {
        is_link_delegate d;
        var p = self->_is_link;
        if (p == _p6) { d = _d6; }
        else
        {
            d = (is_link_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_link_delegate));
            if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
        }
        return d(self);
    }
    
    // IsFragment
    private static IntPtr _p7;
    private static is_fragment_delegate _d7;
    
    public static int is_fragment(cef_drag_data_t* self)
    {
        is_fragment_delegate d;
        var p = self->_is_fragment;
        if (p == _p7) { d = _d7; }
        else
        {
            d = (is_fragment_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_fragment_delegate));
            if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
        }
        return d(self);
    }
    
    // IsFile
    private static IntPtr _p8;
    private static is_file_delegate _d8;
    
    public static int is_file(cef_drag_data_t* self)
    {
        is_file_delegate d;
        var p = self->_is_file;
        if (p == _p8) { d = _d8; }
        else
        {
            d = (is_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_file_delegate));
            if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
        }
        return d(self);
    }
    
    // GetLinkURL
    private static IntPtr _p9;
    private static get_link_url_delegate _d9;
    
    public static cef_string_userfree* get_link_url(cef_drag_data_t* self)
    {
        get_link_url_delegate d;
        var p = self->_get_link_url;
        if (p == _p9) { d = _d9; }
        else
        {
            d = (get_link_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_link_url_delegate));
            if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
        }
        return d(self);
    }
    
    // GetLinkTitle
    private static IntPtr _pa;
    private static get_link_title_delegate _da;
    
    public static cef_string_userfree* get_link_title(cef_drag_data_t* self)
    {
        get_link_title_delegate d;
        var p = self->_get_link_title;
        if (p == _pa) { d = _da; }
        else
        {
            d = (get_link_title_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_link_title_delegate));
            if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
        }
        return d(self);
    }
    
    // GetLinkMetadata
    private static IntPtr _pb;
    private static get_link_metadata_delegate _db;
    
    public static cef_string_userfree* get_link_metadata(cef_drag_data_t* self)
    {
        get_link_metadata_delegate d;
        var p = self->_get_link_metadata;
        if (p == _pb) { d = _db; }
        else
        {
            d = (get_link_metadata_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_link_metadata_delegate));
            if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
        }
        return d(self);
    }
    
    // GetFragmentText
    private static IntPtr _pc;
    private static get_fragment_text_delegate _dc;
    
    public static cef_string_userfree* get_fragment_text(cef_drag_data_t* self)
    {
        get_fragment_text_delegate d;
        var p = self->_get_fragment_text;
        if (p == _pc) { d = _dc; }
        else
        {
            d = (get_fragment_text_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_fragment_text_delegate));
            if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
        }
        return d(self);
    }
    
    // GetFragmentHtml
    private static IntPtr _pd;
    private static get_fragment_html_delegate _dd;
    
    public static cef_string_userfree* get_fragment_html(cef_drag_data_t* self)
    {
        get_fragment_html_delegate d;
        var p = self->_get_fragment_html;
        if (p == _pd) { d = _dd; }
        else
        {
            d = (get_fragment_html_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_fragment_html_delegate));
            if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
        }
        return d(self);
    }
    
    // GetFragmentBaseURL
    private static IntPtr _pe;
    private static get_fragment_base_url_delegate _de;
    
    public static cef_string_userfree* get_fragment_base_url(cef_drag_data_t* self)
    {
        get_fragment_base_url_delegate d;
        var p = self->_get_fragment_base_url;
        if (p == _pe) { d = _de; }
        else
        {
            d = (get_fragment_base_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_fragment_base_url_delegate));
            if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
        }
        return d(self);
    }
    
    // GetFileName
    private static IntPtr _pf;
    private static get_file_name_delegate _df;
    
    public static cef_string_userfree* get_file_name(cef_drag_data_t* self)
    {
        get_file_name_delegate d;
        var p = self->_get_file_name;
        if (p == _pf) { d = _df; }
        else
        {
            d = (get_file_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_name_delegate));
            if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
        }
        return d(self);
    }
    
    // GetFileContents
    private static IntPtr _p10;
    private static get_file_contents_delegate _d10;
    
    public static UIntPtr get_file_contents(cef_drag_data_t* self, cef_stream_writer_t* writer)
    {
        get_file_contents_delegate d;
        var p = self->_get_file_contents;
        if (p == _p10) { d = _d10; }
        else
        {
            d = (get_file_contents_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_contents_delegate));
            if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
        }
        return d(self, writer);
    }
    
    // GetFileNames
    private static IntPtr _p11;
    private static get_file_names_delegate _d11;
    
    public static int get_file_names(cef_drag_data_t* self, cef_string_list* names)
    {
        get_file_names_delegate d;
        var p = self->_get_file_names;
        if (p == _p11) { d = _d11; }
        else
        {
            d = (get_file_names_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_file_names_delegate));
            if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
        }
        return d(self, names);
    }
    
    // SetLinkURL
    private static IntPtr _p12;
    private static set_link_url_delegate _d12;
    
    public static void set_link_url(cef_drag_data_t* self, cef_string_t* url)
    {
        set_link_url_delegate d;
        var p = self->_set_link_url;
        if (p == _p12) { d = _d12; }
        else
        {
            d = (set_link_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_link_url_delegate));
            if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
        }
        d(self, url);
    }
    
    // SetLinkTitle
    private static IntPtr _p13;
    private static set_link_title_delegate _d13;
    
    public static void set_link_title(cef_drag_data_t* self, cef_string_t* title)
    {
        set_link_title_delegate d;
        var p = self->_set_link_title;
        if (p == _p13) { d = _d13; }
        else
        {
            d = (set_link_title_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_link_title_delegate));
            if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
        }
        d(self, title);
    }
    
    // SetLinkMetadata
    private static IntPtr _p14;
    private static set_link_metadata_delegate _d14;
    
    public static void set_link_metadata(cef_drag_data_t* self, cef_string_t* data)
    {
        set_link_metadata_delegate d;
        var p = self->_set_link_metadata;
        if (p == _p14) { d = _d14; }
        else
        {
            d = (set_link_metadata_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_link_metadata_delegate));
            if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
        }
        d(self, data);
    }
    
    // SetFragmentText
    private static IntPtr _p15;
    private static set_fragment_text_delegate _d15;
    
    public static void set_fragment_text(cef_drag_data_t* self, cef_string_t* text)
    {
        set_fragment_text_delegate d;
        var p = self->_set_fragment_text;
        if (p == _p15) { d = _d15; }
        else
        {
            d = (set_fragment_text_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_fragment_text_delegate));
            if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
        }
        d(self, text);
    }
    
    // SetFragmentHtml
    private static IntPtr _p16;
    private static set_fragment_html_delegate _d16;
    
    public static void set_fragment_html(cef_drag_data_t* self, cef_string_t* html)
    {
        set_fragment_html_delegate d;
        var p = self->_set_fragment_html;
        if (p == _p16) { d = _d16; }
        else
        {
            d = (set_fragment_html_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_fragment_html_delegate));
            if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
        }
        d(self, html);
    }
    
    // SetFragmentBaseURL
    private static IntPtr _p17;
    private static set_fragment_base_url_delegate _d17;
    
    public static void set_fragment_base_url(cef_drag_data_t* self, cef_string_t* base_url)
    {
        set_fragment_base_url_delegate d;
        var p = self->_set_fragment_base_url;
        if (p == _p17) { d = _d17; }
        else
        {
            d = (set_fragment_base_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_fragment_base_url_delegate));
            if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
        }
        d(self, base_url);
    }
    
    // ResetFileContents
    private static IntPtr _p18;
    private static reset_file_contents_delegate _d18;
    
    public static void reset_file_contents(cef_drag_data_t* self)
    {
        reset_file_contents_delegate d;
        var p = self->_reset_file_contents;
        if (p == _p18) { d = _d18; }
        else
        {
            d = (reset_file_contents_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(reset_file_contents_delegate));
            if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
        }
        d(self);
    }
    
    // AddFile
    private static IntPtr _p19;
    private static add_file_delegate _d19;
    
    public static void add_file(cef_drag_data_t* self, cef_string_t* path, cef_string_t* display_name)
    {
        add_file_delegate d;
        var p = self->_add_file;
        if (p == _p19) { d = _d19; }
        else
        {
            d = (add_file_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_file_delegate));
            if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
        }
        d(self, path, display_name);
    }
    
    // ClearFilenames
    private static IntPtr _p1a;
    private static clear_filenames_delegate _d1a;
    
    public static void clear_filenames(cef_drag_data_t* self)
    {
        clear_filenames_delegate d;
        var p = self->_clear_filenames;
        if (p == _p1a) { d = _d1a; }
        else
        {
            d = (clear_filenames_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(clear_filenames_delegate));
            if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
        }
        d(self);
    }
    
    // GetImage
    private static IntPtr _p1b;
    private static get_image_delegate _d1b;
    
    public static cef_image_t* get_image(cef_drag_data_t* self)
    {
        get_image_delegate d;
        var p = self->_get_image;
        if (p == _p1b) { d = _d1b; }
        else
        {
            d = (get_image_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_image_delegate));
            if (_p1b == IntPtr.Zero) { _d1b = d; _p1b = p; }
        }
        return d(self);
    }
    
    // GetImageHotspot
    private static IntPtr _p1c;
    private static get_image_hotspot_delegate _d1c;
    
    public static cef_point_t get_image_hotspot(cef_drag_data_t* self)
    {
        get_image_hotspot_delegate d;
        var p = self->_get_image_hotspot;
        if (p == _p1c) { d = _d1c; }
        else
        {
            d = (get_image_hotspot_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_image_hotspot_delegate));
            if (_p1c == IntPtr.Zero) { _d1c = d; _p1c = p; }
        }
        return d(self);
    }
    
    // HasImage
    private static IntPtr _p1d;
    private static has_image_delegate _d1d;
    
    public static int has_image(cef_drag_data_t* self)
    {
        has_image_delegate d;
        var p = self->_has_image;
        if (p == _p1d) { d = _d1d; }
        else
        {
            d = (has_image_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_image_delegate));
            if (_p1d == IntPtr.Zero) { _d1d = d; _p1d = p; }
        }
        return d(self);
    }
    
}