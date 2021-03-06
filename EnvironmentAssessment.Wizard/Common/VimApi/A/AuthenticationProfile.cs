namespace EnvironmentAssessment.Common.VimApi
{
	public class AuthenticationProfile : ApplyProfile
	{
		protected ActiveDirectoryProfile _activeDirectory;
		public ActiveDirectoryProfile ActiveDirectory
		{
			get
			{
				return this._activeDirectory;
			}
			set
			{
				this._activeDirectory = value;
			}
		}
	}
}
