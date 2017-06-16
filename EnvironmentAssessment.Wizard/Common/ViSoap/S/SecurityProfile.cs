namespace EnvironmentAssessment.Common.VISoap
{
    public class SecurityProfile : ApplyProfile
	{
		protected PermissionProfile[] _permission;
		public PermissionProfile[] Permission
		{
			get
			{
				return this._permission;
			}
			set
			{
				this._permission = value;
			}
		}
	}
}
