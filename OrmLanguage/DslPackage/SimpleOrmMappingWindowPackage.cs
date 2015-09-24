﻿//------------------------------------------------------------------------------
// <copyright file="SimpleOrmMappingWindowPackage.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

/*
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;

namespace Company.OrmLanguage
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#1110", "#1112", "1.0", IconResourceID = 1400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(SimpleOrmMappingWindow))]
    [Guid(SimpleOrmMappingWindowPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class SimpleOrmMappingWindowPackage : Package
    {
        /// <summary>
        /// SimpleOrmMappingWindowPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "30e56326-0400-4f2b-a455-19fd3165b23e";

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleOrmMappingWindow"/> class.
        /// </summary>
        public SimpleOrmMappingWindowPackage()
        {
            // Inside this method you can place any initialization code that does not require
            // any Visual Studio service because at this point the package object is created but
            // not sited yet inside Visual Studio environment. The place to do all the other
            // initialization is the Initialize method.
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            SimpleOrmMappingWindowCommand.Initialize(this);
            base.Initialize();
        }

        #endregion
    }
}
*/