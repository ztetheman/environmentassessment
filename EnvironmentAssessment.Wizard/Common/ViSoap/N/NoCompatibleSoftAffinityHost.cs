namespace EnvironmentAssessment.Common.VISoap
{
    public class NoCompatibleSoftAffinityHost : VmConfigFault
	{
		protected string _vmName;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
	}
}