namespace EnvironmentAssessment.Common.VISoap
{
    public class DisallowedMigrationDeviceAttached : MigrationFault
	{
		protected LocalizedMethodFault _fault;
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
