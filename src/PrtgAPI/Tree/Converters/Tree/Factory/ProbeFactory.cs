﻿using System.Collections.Generic;
using System.Linq;
using PrtgAPI.Tree.Internal;

namespace PrtgAPI.Tree.Converters.Tree
{
    /// <summary>
    /// Provides methods for generating and encapsulating <see cref="Probe"/> objects.
    /// </summary>
    class ProbeFactory : ObjectFactory
    {
        /// <summary>
        /// Gets the type of object managed by this factory.
        /// </summary>
        public override PrtgNodeType Type => PrtgNodeType.Probe;

        /// <summary>
        /// Retrieves all <see cref="Probe"/> objects of a specified parent.
        /// </summary>
        /// <param name="parentId">The object to retrieve probes from.</param>
        /// <returns>A list of probes under the specified parent.</returns>
        public override List<ITreeValue> Objects(int parentId) => client.GetProbes(Property.ParentId, parentId).Cast<ITreeValue>().ToList();

        /// <summary>
        /// Encapsulates a <see cref="Probe"/> and its children as a <see cref="ProbeOrphan"/>.
        /// </summary>
        /// <param name="value">The probe to encapsulate.</param>
        /// <param name="children">The children of the probe.</param>
        /// <returns>A <see cref="ProbeOrphan"/> encapsulating the specified <see cref="Probe"/> and children.</returns>
        public override PrtgOrphan Orphan(ITreeValue value, IEnumerable<PrtgOrphan> children) =>
            PrtgOrphan.Probe((Probe) value, children);

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeFactory"/> class.
        /// </summary>
        /// <param name="client">The client this factory should use for executing API requests.</param>
        internal ProbeFactory(PrtgClient client) : base(client)
        {
        }
    }
}
