

public List<Point> Points { get; set; } 
public int Iterations { get; set; } 
public List<string> ClickType { get; set; } 
public List<int> Times { get; set; } 


[DllImport("user32.dll")]
public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

[DllImport("user32.dll", SetLastError = true)]
public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);


public struct INPUT
{
    public uint type;
    public MOUSEINPUT mi;

};


public struct MOUSEINPUT
{
    public int dx;
    public int dy;
    public int mouseData;
    public int dwFlags;
    public int time;
    public IntPtr dwExtraInfo;
};


public const int INPUT_MOUSE = 0x0000;
public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
public const int MOUSEEVENTF_LEFTUP = 0x0004;
public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
public const int MOUSEEVENTF_RIGHTUP = 0x0010;
public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
public const int MOUSEEVENTF_MIDDLEUP = 0x0040;


public void ClickLeftMouseButtonSendInput()
{
    
    INPUT input = new INPUT();
    input.type = INPUT_MOUSE;
    input.mi.dx = 0;
    input.mi.dy = 0;
    input.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
    input.mi.dwExtraInfo = IntPtr.Zero;
    input.mi.mouseData = 0;
    input.mi.time = 0;

   
    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_LEFTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));

}
public void DubbleClickLeftMouseButtonSendInput()
{
    
    INPUT input = new INPUT();
    input.type = INPUT_MOUSE;
    input.mi.dx = 0;
    input.mi.dy = 0;
    input.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
    input.mi.dwExtraInfo = IntPtr.Zero;
    input.mi.mouseData = 0;
    input.mi.time = 0;

    
    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_LEFTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));

    Task.WaitAll(Task.Delay(100));


    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
    SendInput(1, ref input, Marshal.SizeOf(input));

    
    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_LEFTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));
}


public void ClickRightMouseButtonSendInput()
{
    
    INPUT input = new INPUT();
    input.type = INPUT_MOUSE;
    input.mi.dx = 0;
    input.mi.dy = 0;
    input.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
    input.mi.dwExtraInfo = IntPtr.Zero;
    input.mi.mouseData = 0;
    input.mi.time = 0;

    
    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_RIGHTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));
}
public void DubbleClickRightMouseButtonSendInput()
{
    
    INPUT input = new INPUT();
    input.type = INPUT_MOUSE;
    input.mi.dx = 0;
    input.mi.dy = 0;
    input.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
    input.mi.dwExtraInfo = IntPtr.Zero;
    input.mi.mouseData = 0;
    input.mi.time = 0;

    
    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_RIGHTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));

    Task.WaitAll(Task.Delay(100));

    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
    SendInput(1, ref input, Marshal.SizeOf(input));

    SendInput(1, ref input, Marshal.SizeOf(input));
    input.mi.dwFlags = MOUSEEVENTF_RIGHTUP;
    SendInput(1, ref input, Marshal.SizeOf(input));
}
