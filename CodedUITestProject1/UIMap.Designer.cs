﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      このコードは、コード化された UI テスト ビルダーによって生成されました。
//      バージョン: 12.0.0.0
//
//      このファイルへの変更は、正しくない動作の原因になる可能性があり、
//      コードが再生成された場合に失われる可能性があります。
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
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("コード化された UI テスト ビルダー", "12.0.30501.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// private void OnClick(object sender, RoutedEventArgs e)
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfHyperlink uIHereHyperlink = this.UIMainWindowWindow.UIClickhereformoreinfoText.UIHereHyperlink;
            #endregion

            // クリック 'here' リンク
            Mouse.Click(uIHereHyperlink, new Point(10, 4));

            // Access is denied.
        }
        
        #region Properties
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIMainWindowWindow mUIMainWindowWindow;
        #endregion
    }
    
    [GeneratedCode("コード化された UI テスト ビルダー", "12.0.30501.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region 検索条件
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIClickhereformoreinfoText UIClickhereformoreinfoText
        {
            get
            {
                if ((this.mUIClickhereformoreinfoText == null))
                {
                    this.mUIClickhereformoreinfoText = new UIClickhereformoreinfoText(this);
                }
                return this.mUIClickhereformoreinfoText;
            }
        }
        #endregion
        
        #region Fields
        private UIClickhereformoreinfoText mUIClickhereformoreinfoText;
        #endregion
    }
    
    [GeneratedCode("コード化された UI テスト ビルダー", "12.0.30501.0")]
    public class UIClickhereformoreinfoText : WpfText
    {
        
        public UIClickhereformoreinfoText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 検索条件
            this.SearchProperties[WpfText.PropertyNames.Name] = "Click  here  for more information";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfHyperlink UIHereHyperlink
        {
            get
            {
                if ((this.mUIHereHyperlink == null))
                {
                    this.mUIHereHyperlink = new WpfHyperlink(this);
                    #region 検索条件
                    this.mUIHereHyperlink.SearchProperties[WpfHyperlink.PropertyNames.Name] = "here";
                    this.mUIHereHyperlink.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIHereHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private WpfHyperlink mUIHereHyperlink;
        #endregion
    }
}
