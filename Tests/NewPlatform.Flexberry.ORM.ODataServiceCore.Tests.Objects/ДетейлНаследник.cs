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
    /// ДетейлНаследник.
    /// </summary>
    // *** Start programmer edit section *** (ДетейлНаследник CustomAttributes)

    // *** End programmer edit section *** (ДетейлНаследник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДетейлНаследникE", new string[] {
            "prop1",
            "БазовыйКласс"})]
    public class ДетейлНаследник : NewPlatform.Flexberry.ORM.ODataService.Tests.Детейл
    {
        
        private string fprop3;
        
        // *** Start programmer edit section *** (ДетейлНаследник CustomMembers)

        // *** End programmer edit section *** (ДетейлНаследник CustomMembers)

        
        /// <summary>
        /// prop3.
        /// </summary>
        // *** Start programmer edit section *** (ДетейлНаследник.prop3 CustomAttributes)

        // *** End programmer edit section *** (ДетейлНаследник.prop3 CustomAttributes)
        [StrLen(255)]
        public virtual string prop3
        {
            get
            {
                // *** Start programmer edit section *** (ДетейлНаследник.prop3 Get start)

                // *** End programmer edit section *** (ДетейлНаследник.prop3 Get start)
                string result = this.fprop3;
                // *** Start programmer edit section *** (ДетейлНаследник.prop3 Get end)

                // *** End programmer edit section *** (ДетейлНаследник.prop3 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДетейлНаследник.prop3 Set start)

                // *** End programmer edit section *** (ДетейлНаследник.prop3 Set start)
                this.fprop3 = value;
                // *** Start programmer edit section *** (ДетейлНаследник.prop3 Set end)

                // *** End programmer edit section *** (ДетейлНаследник.prop3 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДетейлНаследникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДетейлНаследникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДетейлНаследникE", typeof(NewPlatform.Flexberry.ORM.ODataService.Tests.ДетейлНаследник));
                }
            }
        }
    }
}
