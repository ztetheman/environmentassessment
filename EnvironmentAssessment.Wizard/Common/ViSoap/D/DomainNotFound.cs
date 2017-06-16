namespace EnvironmentAssessment.Common.VISoap
{
    public class DomainNotFound : ActiveDirectoryFault
	{
		protected string _domainName;
		public string DomainName
		{
			get
			{
				return this._domainName;
			}
			set
			{
				this._domainName = value;
			}
		}
	}
}
