namespace EnvironmentAssessment.Common.VISoap
{
    public class DatabaseSizeEstimate : DynamicData
	{
		protected long _size;
		public long Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
			}
		}
	}
}
