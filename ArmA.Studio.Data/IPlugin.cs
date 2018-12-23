﻿using ArmA.Studio.Data.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArmA.Studio.Data
{
    public interface IPlugin
    {
        /// <summary>
        /// Called at program start.
        /// Is expected to return all documents a user can open.
        /// </summary>
        /// <returns>DockableInfos that contain the documents a user can open.</returns>
        IEnumerable<DockableInfo> GetDocuments();
        /// <summary>
        /// Called at program start.
        /// Is expected to return all anchorables a user can open.
        /// </summary>
        /// <returns>DockableInfos that contain the anchorables a user can open.</returns>
        IEnumerable<DockableInfo> GetAnchorables();
        /// <summary>
        /// Called at program start.
        /// Is expected to check for plugin updates.
        /// </summary>
        /// <remarks>
        /// If no update checking mechanism is planned, the following implementation may be used:
        /// <code>public Task<IUpdateInfo> CheckForUpdate(CancellationToken cancellationToken) => Task.Run(() => default(IUpdateInfo));</code>
        /// </remarks>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> that may cancel the asynchronous operation.</param>
        /// <returns>The <see cref="Task"/> promising the <see cref="IUpdateInfo"/> or a <see cref="Task"/> containing null.</returns>
        Task<IUpdateInfo> CheckForUpdate(CancellationToken cancellationToken);
        /// <summary>
        /// Called at program start.
        /// Supposed to do whatever is required to initialize the plugin.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> that may cancel the asynchronous operation.</param>
        /// <returns>Awaitable <see cref="Task"/> or <see cref="Task.CompletedTask"/></returns>
        Task Initialize(CancellationToken cancellationToken);

        /// <summary>
        /// Supposed to add the datatemplates to the <see cref="GenericDataTemplateSelector"/>.
        /// </summary>
        /// <param name="selector">The <see cref="GenericDataTemplateSelector"/> instance.</param>
        void AddDataTemplates(GenericDataTemplateSelector selector);

        /// <summary>
        /// Supposed to return the current plugin version.
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// Supposed to return the localized plugin name.
        /// </summary>
        string Name { get; }
    }
}