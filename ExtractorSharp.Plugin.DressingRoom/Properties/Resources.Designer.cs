﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExtractorSharp.Plugin.DressingRoom.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExtractorSharp.Plugin.DressingRoom.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;swordman&quot;: &quot;鬼剑士(男)&quot;,
        ///  &quot;swordman_at&quot;: &quot;鬼剑士(女)&quot;,
        ///  &quot;fighter_at&quot;: &quot;格斗家(男)&quot;,
        ///  &quot;fighter&quot;: &quot;格斗家(女)&quot;,
        ///  &quot;mage_at&quot;: &quot;魔法师(男)&quot;,
        ///  &quot;mage&quot;: &quot;魔法师(女)&quot;,
        ///  &quot;gunner&quot;: &quot;神枪手(男)&quot;,
        ///  &quot;gunner_at&quot;: &quot;神枪手(女)&quot;,
        ///  &quot;priest&quot;: &quot;圣职者(男)&quot;,
        ///  &quot;priest_at&quot;: &quot;圣职者(女)&quot;,
        ///  &quot;thief&quot;: &quot;暗夜使者(女)&quot;,
        ///  &quot;knight&quot;: &quot;守护者(女)&quot;,
        ///  &quot;demoniclancer&quot;: &quot;魔枪士(男)&quot;,
        ///
        ///  &quot;hair&quot;: &quot;头发&quot;,
        ///  &quot;cap&quot;: &quot;帽子&quot;,
        ///  &quot;face&quot;: &quot;脸部&quot;,
        ///  &quot;neck&quot;: &quot;胸部&quot;,
        ///  &quot;coat&quot;: &quot;上衣&quot;,
        ///  &quot;skin&quot;: &quot;皮肤&quot;,
        ///  &quot;belt&quot;: &quot;腰带&quot;,
        ///  &quot;pants&quot;: &quot;裤子&quot;,
        ///  &quot;shoes&quot;: &quot;鞋子&quot;,
        ///
        ///
        ///  &quot;katana&quot;: &quot;太刀&quot;,
        ///  &quot;sswd [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Alias_weapon {
            get {
                return ResourceManager.GetString("Alias_weapon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Back {
            get {
                object obj = ResourceManager.GetObject("Back", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;swordman&quot;: {
        ///    &quot;hasAt&quot;: true,
        ///    &quot;weapon&quot;: [
        ///      &quot;katana&quot;,
        ///      &quot;lkatana&quot;,
        ///      &quot;sswd&quot;,
        ///      &quot;lswd&quot;,
        ///      &quot;lswd_teen&quot;,
        ///      &quot;lgswd&quot;,
        ///      &quot;mswd&quot;,
        ///      &quot;club&quot;,
        ///      &quot;gemswd&quot;,
        ///      &quot;beamswd&quot;
        ///    ],
        ///    //
        ///    &quot;alias&quot;: {
        ///      &quot;bswd&quot;: &quot;boneswd&quot;
        ///    }
        ///  },
        ///  &quot;fighter&quot;: {
        ///    &quot;hasAt&quot;: true,
        ///    &quot;weapon&quot;: [
        ///      &quot;arm&quot;,
        ///      &quot;tonfa&quot;,
        ///      &quot;lkatana&quot;,
        ///      &quot;glove&quot;,
        ///      &quot;knuckle&quot;,
        ///      &quot;claw&quot;,
        ///      &quot;gauntlet&quot;
        ///    ],
        ///    &quot;alias&quot;: {
        ///      &quot;bglove&quot;: &quot;boneglove&quot;, [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Weapon {
            get {
                return ResourceManager.GetString("Weapon", resourceCulture);
            }
        }
    }
}
