namespace EnvironmentAssessment.Common.VimApi
{
	public class NotSupportedDeviceForFT_LinkedView
	{
		protected HostSystem _host;
		protected VirtualMachine _vm;
		public HostSystem Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public VirtualMachine Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
	}
}
