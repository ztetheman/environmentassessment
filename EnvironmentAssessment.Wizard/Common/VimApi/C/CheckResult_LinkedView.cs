namespace EnvironmentAssessment.Common.VimApi
{
	public class CheckResult_LinkedView
	{
		protected VirtualMachine _vm;
		protected HostSystem _host;
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
	}
}
