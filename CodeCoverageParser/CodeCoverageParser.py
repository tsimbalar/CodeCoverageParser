

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

    print dir(deserialized)

    for item in deserialized.Items:
        #print item
        if type(item) is CoverageXml.Model.CoverageDSPrivModule :
            #print "CoverageDSPrivModule"
            print item.ModuleName
        elif type(item) is CoverageXml.Model.CoverageDSPrivSourceFileNames :
            #print "CoverageDSPrivSourceFileNames"
            print item.SourceFileName    
        else:
            raise("unknown type : %s " % (type(item),))  

    raw_input("press any key to continue or whatever ...")

#trick to run only directly, not when imported as a module...
if __name__ == "__main__":
    main()