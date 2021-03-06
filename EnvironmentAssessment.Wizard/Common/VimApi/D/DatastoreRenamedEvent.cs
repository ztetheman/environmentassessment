namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreRenamedEvent : DatastoreEvent
	{
		protected string _oldName;
		protected string _newName;
		public string OldName
		{
			get
			{
				return this._oldName;
			}
			set
			{
				this._oldName = value;
			}
		}
		public string NewName
		{
			get
			{
				return this._newName;
			}
			set
			{
				this._newName = value;
			}
		}
	}
}
