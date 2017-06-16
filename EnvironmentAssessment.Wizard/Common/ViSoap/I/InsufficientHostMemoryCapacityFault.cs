namespace EnvironmentAssessment.Common.VISoap
{
    public class InsufficientHostMemoryCapacityFault : InsufficientHostCapacityFault
	{
		protected long _unreserved;
		protected long _requested;
		public long Unreserved
		{
			get
			{
				return this._unreserved;
			}
			set
			{
				this._unreserved = value;
			}
		}
		public long Requested
		{
			get
			{
				return this._requested;
			}
			set
			{
				this._requested = value;
			}
		}
		public new InsufficientHostMemoryCapacityFault_LinkedView LinkedView
		{
			get
			{
				return (InsufficientHostMemoryCapacityFault_LinkedView)this._linkedView;
			}
		}
	}
}
