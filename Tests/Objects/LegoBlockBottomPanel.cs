﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.ODataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// LegoBlockBottomPanel.
    /// </summary>
    // *** Start programmer edit section *** (LegoBlockBottomPanel CustomAttributes)

    // *** End programmer edit section *** (LegoBlockBottomPanel CustomAttributes)
    [PublishName("LegoBlockBottomPanel")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class LegoBlockBottomPanel : ICSSoft.STORMNET.DataObject
    {
        
        private int fWidthCount;
        
        private int fHeightCount;
        
        private NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlock fBlock;
        
        // *** Start programmer edit section *** (LegoBlockBottomPanel CustomMembers)

        // *** End programmer edit section *** (LegoBlockBottomPanel CustomMembers)

        
        /// <summary>
        /// WidthCount.
        /// </summary>
        // *** Start programmer edit section *** (LegoBlockBottomPanel.WidthCount CustomAttributes)

        // *** End programmer edit section *** (LegoBlockBottomPanel.WidthCount CustomAttributes)
        public virtual int WidthCount
        {
            get
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.WidthCount Get start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.WidthCount Get start)
                int result = this.fWidthCount;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.WidthCount Get end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.WidthCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.WidthCount Set start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.WidthCount Set start)
                this.fWidthCount = value;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.WidthCount Set end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.WidthCount Set end)
            }
        }
        
        /// <summary>
        /// HeightCount.
        /// </summary>
        // *** Start programmer edit section *** (LegoBlockBottomPanel.HeightCount CustomAttributes)

        // *** End programmer edit section *** (LegoBlockBottomPanel.HeightCount CustomAttributes)
        public virtual int HeightCount
        {
            get
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.HeightCount Get start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.HeightCount Get start)
                int result = this.fHeightCount;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.HeightCount Get end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.HeightCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.HeightCount Set start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.HeightCount Set start)
                this.fHeightCount = value;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.HeightCount Set end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.HeightCount Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlock.
        /// </summary>
        // *** Start programmer edit section *** (LegoBlockBottomPanel.Block CustomAttributes)

        // *** End programmer edit section *** (LegoBlockBottomPanel.Block CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Block"})]
        public virtual NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlock Block
        {
            get
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.Block Get start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.Block Get start)
                NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlock result = this.fBlock;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.Block Get end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.Block Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (LegoBlockBottomPanel.Block Set start)

                // *** End programmer edit section *** (LegoBlockBottomPanel.Block Set start)
                this.fBlock = value;
                // *** Start programmer edit section *** (LegoBlockBottomPanel.Block Set end)

                // *** End programmer edit section *** (LegoBlockBottomPanel.Block Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of LegoBlockBottomPanel.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfLegoBlockBottomPanel CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfLegoBlockBottomPanel CustomAttributes)
    public class DetailArrayOfLegoBlockBottomPanel : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ORM.ODataService.Tests.DetailArrayOfLegoBlockBottomPanel members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ORM.ODataService.Tests.DetailArrayOfLegoBlockBottomPanel members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type LegoBlockBottomPanel by index.
        /// </summary>
        /// <summary>
        /// Adds object with type LegoBlockBottomPanel.
        /// </summary>
        public DetailArrayOfLegoBlockBottomPanel(NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlock fLegoBlock) : 
                base(typeof(LegoBlockBottomPanel), ((ICSSoft.STORMNET.DataObject)(fLegoBlock)))
        {
        }
        
        public NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlockBottomPanel this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlockBottomPanel)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ORM.ODataService.Tests.LegoBlockBottomPanel dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
