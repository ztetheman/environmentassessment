using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class FileInfo : DynamicData
	{
		protected string _path;
		protected long? _fileSize;
		protected DateTime? _modification;
		protected string _owner;
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public long? FileSize
		{
			get
			{
				return this._fileSize;
			}
			set
			{
				this._fileSize = value;
			}
		}
		public DateTime? Modification
		{
			get
			{
				return this._modification;
			}
			set
			{
				this._modification = value;
			}
		}
		public string Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
			}
		}
	}
}
