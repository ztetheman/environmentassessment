namespace EnvironmentAssessment.Common.VISoap
{
    public class AnswerFileUpdateFailed : VimFault
	{
		protected AnswerFileUpdateFailure[] _failure;
		public AnswerFileUpdateFailure[] Failure
		{
			get
			{
				return this._failure;
			}
			set
			{
				this._failure = value;
			}
		}
	}
}
