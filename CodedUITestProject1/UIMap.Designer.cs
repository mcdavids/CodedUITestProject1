﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// insert test subtask
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinClient uIChromeLegacyWindowClient = this.UIToDoRailsandAngularGWindow.UIChromeLegacyWindowWindow.UIChromeLegacyWindowClient;
            WinControl uIToDoRailsandAngularGDocument = this.UIToDoRailsandAngularGWindow.UIToDoRailsandAngularGDocument;
            WinControl uIChromeLegacyWindowDocument = this.UIToDoRailsandAngularGWindow.UIChromeLegacyWindowDocument;
            #endregion

            // Click 'Chrome Legacy Window' client
            Mouse.Click(uIChromeLegacyWindowClient, new Point(738, 109));

            // Type 'test recorded 1' in 'ToDo Rails and Angular - Google Chrome' document
            Keyboard.SendKeys(uIToDoRailsandAngularGDocument, this.RecordedMethod1Params.UIToDoRailsandAngularGDocumentSendKeys, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(570, 222));
        }
        
        /// <summary>
        /// test2
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WinControl uIToDoRailsandAngularGDocument = this.UIToDoRailsandAngularGWindow.UIToDoRailsandAngularGDocument;
            #endregion

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(573, 153));

            // Type 'test 3' in 'ToDo Rails and Angular - Google Chrome' document
            Keyboard.SendKeys(uIToDoRailsandAngularGDocument, this.RecordedMethod2Params.UIToDoRailsandAngularGDocumentSendKeys, ModifierKeys.None);

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(1322, 166));

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(1112, 315));

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(651, 310));

            // Type 'subtest 3' in 'ToDo Rails and Angular - Google Chrome' document
            Keyboard.SendKeys(uIToDoRailsandAngularGDocument, this.RecordedMethod2Params.UIToDoRailsandAngularGDocumentSendKeys1, ModifierKeys.None);

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(546, 428));

            // Click 'ToDo Rails and Angular - Google Chrome' document
            Mouse.Click(uIToDoRailsandAngularGDocument, new Point(1048, 660));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual RecordedMethod2Params RecordedMethod2Params
        {
            get
            {
                if ((this.mRecordedMethod2Params == null))
                {
                    this.mRecordedMethod2Params = new RecordedMethod2Params();
                }
                return this.mRecordedMethod2Params;
            }
        }
        
        public UIToDoRailsandAngularGWindow UIToDoRailsandAngularGWindow
        {
            get
            {
                if ((this.mUIToDoRailsandAngularGWindow == null))
                {
                    this.mUIToDoRailsandAngularGWindow = new UIToDoRailsandAngularGWindow();
                }
                return this.mUIToDoRailsandAngularGWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private RecordedMethod2Params mRecordedMethod2Params;
        
        private UIToDoRailsandAngularGWindow mUIToDoRailsandAngularGWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'test recorded 1' in 'ToDo Rails and Angular - Google Chrome' document
        /// </summary>
        public string UIToDoRailsandAngularGDocumentSendKeys = "test recorded 1";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod2Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'test 3' in 'ToDo Rails and Angular - Google Chrome' document
        /// </summary>
        public string UIToDoRailsandAngularGDocumentSendKeys = "test 3";
        
        /// <summary>
        /// Type 'subtest 3' in 'ToDo Rails and Angular - Google Chrome' document
        /// </summary>
        public string UIToDoRailsandAngularGDocumentSendKeys1 = "subtest 3";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIToDoRailsandAngularGWindow : WinWindow
    {
        
        public UIToDoRailsandAngularGWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ToDo Rails and Angular - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("ToDo Rails and Angular - Google Chrome");
            #endregion
        }
        
        #region Properties
        public UIChromeLegacyWindowWindow UIChromeLegacyWindowWindow
        {
            get
            {
                if ((this.mUIChromeLegacyWindowWindow == null))
                {
                    this.mUIChromeLegacyWindowWindow = new UIChromeLegacyWindowWindow(this);
                }
                return this.mUIChromeLegacyWindowWindow;
            }
        }
        
        public WinControl UIToDoRailsandAngularGDocument
        {
            get
            {
                if ((this.mUIToDoRailsandAngularGDocument == null))
                {
                    this.mUIToDoRailsandAngularGDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIToDoRailsandAngularGDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIToDoRailsandAngularGDocument.WindowTitles.Add("ToDo Rails and Angular - Google Chrome");
                    #endregion
                }
                return this.mUIToDoRailsandAngularGDocument;
            }
        }
        
        public WinControl UIChromeLegacyWindowDocument
        {
            get
            {
                if ((this.mUIChromeLegacyWindowDocument == null))
                {
                    this.mUIChromeLegacyWindowDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIChromeLegacyWindowDocument.WindowTitles.Add("ToDo Rails and Angular - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIChromeLegacyWindowWindow mUIChromeLegacyWindowWindow;
        
        private WinControl mUIToDoRailsandAngularGDocument;
        
        private WinControl mUIChromeLegacyWindowDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIChromeLegacyWindowWindow : WinWindow
    {
        
        public UIChromeLegacyWindowWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1479453392";
            this.WindowTitles.Add("ToDo Rails and Angular - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinClient UIChromeLegacyWindowClient
        {
            get
            {
                if ((this.mUIChromeLegacyWindowClient == null))
                {
                    this.mUIChromeLegacyWindowClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowClient.SearchProperties[WinControl.PropertyNames.Name] = "Chrome Legacy Window";
                    this.mUIChromeLegacyWindowClient.WindowTitles.Add("ToDo Rails and Angular - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIChromeLegacyWindowClient;
        #endregion
    }
}
