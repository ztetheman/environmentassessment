namespace EnvironmentAssessment.Common.VISoap
{
    public class RecurrentTaskScheduler : TaskScheduler
	{
		protected int _interval;
		public int Interval
		{
			get
			{
				return this._interval;
			}
			set
			{
				this._interval = value;
			}
		}
	}
}
