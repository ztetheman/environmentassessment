namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineImportSpec_LinkedView
	{
		protected ResourcePool _resPoolEntity;
		public ResourcePool ResPoolEntity
		{
			get
			{
				return this._resPoolEntity;
			}
			set
			{
				this._resPoolEntity = value;
			}
		}
	}
}
