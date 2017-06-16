namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfInvalidPackage : OvfFault
	{
		protected int _lineNumber;
		public int LineNumber
		{
			get
			{
				return this._lineNumber;
			}
			set
			{
				this._lineNumber = value;
			}
		}
	}
}
