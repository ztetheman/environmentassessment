namespace EnvironmentAssessment.Common.VISoap
{
    public class ActiveDirectoryFault : VimFault
	{
		protected int? _errorCode;
		public int? ErrorCode
		{
			get
			{
				return this._errorCode;
			}
			set
			{
				this._errorCode = value;
			}
		}
	}
}
