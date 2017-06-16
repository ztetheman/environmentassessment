namespace Standard
{
    internal enum WM
	{
		NULL,
		CREATE,
		DESTROY,
		MOVE,
		SIZE = 5,
		ACTIVATE,
		SETFOCUS,
		KILLFOCUS,
		ENABLE = 10,
		SETREDRAW,
		SETTEXT,
		GETTEXT,
		GETTEXTLENGTH,
		PAINT,
		CLOSE,
		QUERYENDSESSION,
		QUIT,
		QUERYOPEN,
		ERASEBKGND,
		SYSCOLORCHANGE,
		SHOWWINDOW = 24,
		CTLCOLOR,
		WININICHANGE,
		SETTINGCHANGE = 26,
		ACTIVATEAPP = 28,
		SETCURSOR = 32,
		MOUSEACTIVATE,
		CHILDACTIVATE,
		QUEUESYNC,
		GETMINMAXINFO,
		WINDOWPOSCHANGING = 70,
		WINDOWPOSCHANGED,
		CONTEXTMENU = 123,
		STYLECHANGING,
		STYLECHANGED,
		DISPLAYCHANGE,
		GETICON,
		SETICON,
		NCCREATE,
		NCDESTROY,
		NCCALCSIZE,
		NCHITTEST,
		NCPAINT,
		NCACTIVATE,
		GETDLGCODE,
		SYNCPAINT,
		NCMOUSEMOVE = 160,
		NCLBUTTONDOWN,
		NCLBUTTONUP,
		NCLBUTTONDBLCLK,
		NCRBUTTONDOWN,
		NCRBUTTONUP,
		NCRBUTTONDBLCLK,
		NCMBUTTONDOWN,
		NCMBUTTONUP,
		NCMBUTTONDBLCLK,
		SYSKEYDOWN = 260,
		SYSKEYUP,
		SYSCHAR,
		SYSDEADCHAR,
		COMMAND = 273,
		SYSCOMMAND,
		MOUSEMOVE = 512,
		LBUTTONDOWN,
		LBUTTONUP,
		LBUTTONDBLCLK,
		RBUTTONDOWN,
		RBUTTONUP,
		RBUTTONDBLCLK,
		MBUTTONDOWN,
		MBUTTONUP,
		MBUTTONDBLCLK,
		MOUSEWHEEL,
		XBUTTONDOWN,
		XBUTTONUP,
		XBUTTONDBLCLK,
		MOUSEHWHEEL,
		PARENTNOTIFY = 528,
		CAPTURECHANGED = 533,
		POWERBROADCAST = 536,
		DEVICECHANGE,
		ENTERSIZEMOVE = 561,
		EXITSIZEMOVE,
		IME_SETCONTEXT = 641,
		IME_NOTIFY,
		IME_CONTROL,
		IME_COMPOSITIONFULL,
		IME_SELECT,
		IME_CHAR,
		IME_REQUEST = 648,
		IME_KEYDOWN = 656,
		IME_KEYUP,
		NCMOUSELEAVE = 674,
		TABLET_DEFBASE = 704,
		TABLET_ADDED = 712,
		TABLET_DELETED,
		TABLET_FLICK = 715,
		TABLET_QUERYSYSTEMGESTURESTATUS,
		CUT = 768,
		COPY,
		PASTE,
		CLEAR,
		UNDO,
		RENDERFORMAT,
		RENDERALLFORMATS,
		DESTROYCLIPBOARD,
		DRAWCLIPBOARD,
		PAINTCLIPBOARD,
		VSCROLLCLIPBOARD,
		SIZECLIPBOARD,
		ASKCBFORMATNAME,
		CHANGECBCHAIN,
		HSCROLLCLIPBOARD,
		QUERYNEWPALETTE,
		PALETTEISCHANGING,
		PALETTECHANGED,
		HOTKEY,
		PRINT = 791,
		PRINTCLIENT,
		APPCOMMAND,
		THEMECHANGED,
		DWMCOMPOSITIONCHANGED = 798,
		DWMNCRENDERINGCHANGED,
		DWMCOLORIZATIONCOLORCHANGED,
		DWMWINDOWMAXIMIZEDCHANGE,
		GETTITLEBARINFOEX = 831,
		DWMSENDICONICTHUMBNAIL = 803,
		DWMSENDICONICLIVEPREVIEWBITMAP = 806,
		USER = 1024,
		TRAYMOUSEMESSAGE = 2048,
		APP = 32768
	}
}
