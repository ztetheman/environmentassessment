namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestProcessNotFound : GuestOperationsFault
	{
		protected long _pid;
		public long Pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				this._pid = value;
			}
		}
	}
}
