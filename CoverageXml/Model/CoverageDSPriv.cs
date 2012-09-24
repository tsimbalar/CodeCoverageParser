using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoverageXml.Model
{
    // ReSharper disable InconsistentNaming
    partial class CoverageDSPriv
    // ReSharper restore InconsistentNaming
    {

        /// <summary>
        ///  Returns the module from the coverage file
        /// </summary>
        public IEnumerable<CoverageDSPrivModule> Modules { get { return this.Items.OfType<CoverageDSPrivModule>(); } }

        /// <summary>
        /// All the source files covered by the coverage file ...
        /// </summary>
        public IDictionary<uint, string> SourceFiles
        {
            get
            {
                return this.Items.OfType<CoverageDSPrivSourceFileNames>().ToDictionary(sf => sf.SourceFileID,
                                                                                       sf => sf.SourceFileName);
            }
        }

    }
}
