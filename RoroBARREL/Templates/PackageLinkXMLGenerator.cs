﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace RoroBARREL.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class PackageLinkXMLGenerator : PackageLinkXMLGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""UTF-8""?> 
 
<XMBML version=""1.0"">
	<View id=""package_link""> 
		<Attributes> 
			<Table key=""pkg_main"">
				<Pair key=""icon_rsc""><String>tex_album_icon</String></Pair>
				<Pair key=""icon_notation""><String>WNT_XmbItemAlbum</String></Pair>
				<Pair key=""title""><String>★ Install Packages From Webserver</String></Pair>
				<Pair key=""info""><String>");
            
            #line 11 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Directory));
            
            #line default
            #line hidden
            this.Write(" on ");
            
            #line 11 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            this.Write(@"</String></Pair>
				<Pair key=""ingame""><String>disable</String></Pair>
			</Table>
		</Attributes>
			<Items>
			<Query 
				class=""type:x-xmb/folder-pixmap""
				key=""pkg_main""
				attr=""pkg_main""
				src=""#pkg_items""/>
			</Items>
		</View>
		<View id=""pkg_items"">	
		<Attributes
			<Table key=""pkg_000"">
				<Pair key=""icon""><String>http://");
            
            #line 18 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IconsDirectory));
            
            #line default
            #line hidden
            this.Write("Refresh_Package_List.PNG</String></Pair>\n\t\t\t\t<Pair key=\"title\"><String>Refresh Pa" +
                    "ckage List</String></Pair>\n \t\t\t\t<Pair key=\"info\"><String>Reboot Required After R" +
                    "efreshing List</String></Pair>\n \t\t\t</Table>\r\n\t\t\t");
            
            #line 19 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 for(int i=0;i<PKGs.Length;i++){ 
            
            #line default
            #line hidden
            this.Write("\t\t\t<Table key=\"pkg_");
            
            #line 20 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\">\r\n\t\t\t\t<Pair key=\"icon\"><String>http://");
            
            #line 21 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IconsDirectory));
            
            #line default
            #line hidden
            this.Write(@"NPJB00486_The_Idolm@ster_Shiny_TV_-_Bonus_Song_-_Arcadia.PNG</String></Pair>
				<Pair key=""title""><String>NPJB00486 The Idolm@ster Shiny TV - Bonus Song - Arcadia</String></Pair>
				<Pair key=""info""><String>NPJB00486   127.5 MB</String></Pair>
 			</Table>
			");
            
            #line 25 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</Attributes>\n\t\t\t<Items>\r\n\t\t\t<Query\n\t\t\t\tclass=\"type:x-xmb/folder-pixmap\"\n\t\t\t\tke" +
                    "y=\"pkg_000\"\n\t\t\t\tattr=\"pkg_000\"\n\t\t\t\tsrc=\"#pkg_000_item\"/>\r\n\t\t");
            
            #line 28 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 for(int i=0;i<PKGs.Length;i++){ 
            
            #line default
            #line hidden
            this.Write("\t\t\t<Query\n\t\t\t\tclass=\"type:x-xmb/folder-pixmap\"\r\n\t\t\t\tkey=\"pkg_");
            
            #line 30 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\"\r\n\t\t\t\tattr=\"pkg_");
            
            #line 31 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\"\r\n\t\t\t\tsrc=\"#pkg_");
            
            #line 32 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("_item\"/>\r\n\t\t");
            
            #line 33 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t</Items>\n\t\t</View>\n\r\n\t\t<View id=\"pkg_000_item\">\n\t\t<Attributes>\n\t\t\t<Table key=\"" +
                    "link000\">\n\t\t\t\t<Pair key=\"info\"><String>net_package_install</String></Pair>\n\t\t\t\t<" +
                    "Pair key=\"pkg_src\"><String>http://");
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PKGDirectory));
            
            #line default
            #line hidden
            this.Write("/Package_List.pkg</String></Pair>\n\t\t\t\t<Pair key=\"pkg_src_qa\"><String>http://");
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PKGDirectory));
            
            #line default
            #line hidden
            this.Write("/Package_List.pkg</String></Pair>\n\t\t\t\t<Pair key=\"content_name\"><String>pkg_instal" +
                    "l_pc</String></Pair>\n\t\t\t\t<Pair key=\"content_id\"><String>");
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PKGLinkContentID));
            
            #line default
            #line hidden
            this.Write("</String></Pair>\n\t\t\t\t<Pair key=\"prod_pict_path\"><String>http://");
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 35 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IconsDirectory));
            
            #line default
            #line hidden
            this.Write("Refresh_Package_List.PNG</String></Pair>\n\t\t\t</Table>\n \t\t</Attributes>\n \t\t\t<Items>" +
                    "\n\t\t\t<Item class=\"type:x-xmb/xmlnpsignup\" key=\"link000\" attr=\"link000\"/>\n\t\t</Item" +
                    "s>\n \t\t</View>\r\n");
            
            #line 36 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 for(int i=0;i<PKGs.Length;i++){ 
            
            #line default
            #line hidden
            this.Write("\t\t<View id=\"pkg_");
            
            #line 37 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("_item\">\r\n\t\t<Attributes>\r\n\t\t\t<Table key=\"link");
            
            #line 39 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\">\r\n\t\t\t\t<Pair key=\"info\"><String>net_package_install</String></Pair>\r\n\t\t\t\t<Pair k" +
                    "ey=\"pkg_src\"><String>http://");
            
            #line 41 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 41 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PKGDirectory));
            
            #line default
            #line hidden
            this.Write("/NPJB00486_The_Idolm@ster_Shiny_TV_-_Bonus_Song_-_Arcadia.pkg</String></Pair>\r\n\t\t" +
                    "\t\t<Pair key=\"pkg_src_qa\"><String>http://");
            
            #line 42 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 42 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PKGDirectory));
            
            #line default
            #line hidden
            this.Write(@"/NPJB00486_The_Idolm@ster_Shiny_TV_-_Bonus_Song_-_Arcadia.pkg</String></Pair>
				<Pair key=""content_name""><String>pkg_install_pc</String></Pair>
				<Pair key=""content_id""><String>JP0700-NPJB00486_00-IMASSFMUSIC00002</String></Pair>
				<Pair key=""prod_pict_path""><String>http://");
            
            #line 45 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Host));
            
            #line default
            #line hidden
            
            #line 45 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IconsDirectory));
            
            #line default
            #line hidden
            this.Write("NPJB00486_The_Idolm@ster_Shiny_TV_-_Bonus_Song_-_Arcadia.PNG</String></Pair>\r\n \t\t" +
                    "\t</Table> \n\t\t</Attributes> \n\t\t\t<Items>\r\n\t\t\t<Item class=\"type:x-xmb/xmlnpsignup\" " +
                    "key=\"link");
            
            #line 47 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\" attr=\"link");
            
            #line 47 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 String.Format("{0:000}", i+1); 
            
            #line default
            #line hidden
            this.Write("\"/>\r\n\t\t</Items> \n\t\t</View> \n\t\t");
            
            #line 48 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\r\n</XMBML>\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 53 "C:\Users\sifir\source\repos\RoroBARREL\RoroBARREL\Templates\PackageLinkXMLGenerator.tt"
 public string[] PKGs;
	public string Host;
	public string Directory;
	public string IconsDirectory="/bin/icons/";
	public string PKGDirectory="";
	public string PKGLinkContentID;
	
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class PackageLinkXMLGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
