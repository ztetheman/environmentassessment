namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualPortgroupInfo : DynamicData
	{
		protected string _switchName;
		protected string _switchUuid;
		protected string _portgroupName;
		protected string _portgroupKey;
		protected string _portgroupType;
		protected bool _uplinkPortgroup;
		protected ManagedObjectReference _portgroup;
		protected bool? _networkReservationSupported;
		protected DistributedVirtualPortgroupInfo_LinkedView _linkedView;
		public string SwitchName
		{
			get
			{
				return this._switchName;
			}
			set
			{
				this._switchName = value;
			}
		}
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
		public string PortgroupName
		{
			get
			{
				return this._portgroupName;
			}
			set
			{
				this._portgroupName = value;
			}
		}
		public string PortgroupKey
		{
			get
			{
				return this._portgroupKey;
			}
			set
			{
				this._portgroupKey = value;
			}
		}
		public string PortgroupType
		{
			get
			{
				return this._portgroupType;
			}
			set
			{
				this._portgroupType = value;
			}
		}
		public bool UplinkPortgroup
		{
			get
			{
				return this._uplinkPortgroup;
			}
			set
			{
				this._uplinkPortgroup = value;
			}
		}
		public ManagedObjectReference Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public bool? NetworkReservationSupported
		{
			get
			{
				return this._networkReservationSupported;
			}
			set
			{
				this._networkReservationSupported = value;
			}
		}
		public DistributedVirtualPortgroupInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
