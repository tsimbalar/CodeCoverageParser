

def main():
    #bootstrap to access .NET CLR types ... System is available by default
    import clr

    import pprint


    clr.AddReference('CoverageXml')
    import CoverageXml.Model


    clr.AddReference("System.Xml")
    import System.Xml
    import System.IO
    import System.Text

    reader = System.Xml.XmlTextReader(r"C:\Users\tdesodt\Desktop\TFSBuildUser_TFSBUILDCTRL1 2012-09-20 16_08_14_Any CPU_Release.coveragexml")
    deserializer = System.Xml.Serialization.XmlSerializer(CoverageXml.Model.CoverageDSPriv)

    # should be a CoverageXml.Xml.Model.CoverageDSPriv
    deserialized = deserializer.Deserialize(reader)

    print "%s source files" % deserialized.SourceFiles.Count

    for i, analyzed_module in enumerate( deserialized.Modules):
        print "- ", i, " ", analyzed_module.ModuleName
        print dir(analyzed_module)

    
        

    raw_input("press any key to continue or whatever ...")

#trick to run only directly, not when imported as a module...
if __name__ == "__main__":
    main()