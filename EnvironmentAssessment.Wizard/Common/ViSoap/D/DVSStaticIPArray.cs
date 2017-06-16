namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSStaticIPArray : InheritablePolicy
	{
		protected DVSIPEntry[] _ipEntries;
		public DVSIPEntry[] IpEntries
		{
			get
			{
				return this._ipEntries;
			}
			set
			{
				this._ipEntries = value;
			}
		}
	}
}
