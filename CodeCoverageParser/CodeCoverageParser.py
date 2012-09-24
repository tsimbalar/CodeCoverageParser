import clr #bootstrap to access .NET CLR types ... System is available by default
clr.AddReference('CoverageXml') # make CoverageXml accessible ...
import CoverageXml.Model # ... and import it

clr.AddReference("System.Xml")
import System.Xml


def extract_coverage_info(obj):
    """ Extract the coverage info of a Coverage-like object, and returns it as a dictionary"""
    props = dir(obj) # access the list of properties of the object
    # take properties starting with Blocks and Lines ... but not ending with Specified
    coverage_info = ( [(k, int( obj.__getattribute__(k))) for k in props if k.startswith("Lines") and not k.endswith("Specified")] + 
      [(k, str( obj.__getattribute__(k))) for k in props if k.startswith("Blocks") and not k.endswith("Specified")] )

    coverage_info = [(k,v) for (k,v) in coverage_info if obj.__getattribute__(k + "Specified")]


    return dict(coverage_info)

def load_coverage_file(file_path):
    """Deserializes an xml coverage file """
    reader = System.Xml.XmlTextReader(file_path)
    deserializer = System.Xml.Serialization.XmlSerializer(CoverageXml.Model.CoverageDSPriv)
    # should be a CoverageXml.Xml.Model.CoverageDSPriv
    deserialized = deserializer.Deserialize(reader)
    return deserialized


def main():    

    # should be a CoverageXml.Xml.Model.CoverageDSPriv
    deserialized = load_coverage_file(r"C:\Users\tdesodt\Desktop\TFSBuildUser_TFSBUILDCTRL1 2012-09-20 16_08_14_Any CPU_Release.coveragexml")

    print "%s source files" % deserialized.SourceFiles.Count

    for i, analyzed_module in enumerate( deserialized.Modules):
        print "- ", i, " ", analyzed_module.ModuleName

        for infoTuple in extract_coverage_info(analyzed_module).items():
            print "\t%s :\t%s" % (infoTuple)
    raw_input("press any key to continue or whatever ...")

#trick to run only directly, not when imported as a module...
if __name__ == "__main__":
    main()