namespace EnvironmentAssessment.Common.VISoap
{
    public class MonthlyByDayTaskScheduler : MonthlyTaskScheduler
	{
		protected int _day;
		public int Day
		{
			get
			{
				return this._day;
			}
			set
			{
				this._day = value;
			}
		}
	}
}
