namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationGuiRunOnce : DynamicData
	{
		protected string[] _commandList;
		public string[] CommandList
		{
			get
			{
				return this._commandList;
			}
			set
			{
				this._commandList = value;
			}
		}
	}
}
