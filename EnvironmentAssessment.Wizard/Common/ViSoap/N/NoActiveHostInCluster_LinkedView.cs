namespace EnvironmentAssessment.Common.VISoap
{
    public class NoActiveHostInCluster_LinkedView
	{
		protected ComputeResource _computeResource;
		public ComputeResource ComputeResource
		{
			get
			{
				return this._computeResource;
			}
			set
			{
				this._computeResource = value;
			}
		}
	}
}
