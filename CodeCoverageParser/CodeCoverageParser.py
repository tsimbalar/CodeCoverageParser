import clr #bootstrap to access .NET CLR types ... System is available by default
clr.AddReference('CoverageXml') # make CoverageXml accessible ...
import CoverageXml.Model # ... and import it

clr.AddReference("System.Xml")
import System.Xml


def extract_coverage_info(obj):
    """ Extract the coverage info of a Coverage-like object, and returns it as a dictionary"""
    props = dir(obj) # access the list of properties of the object
    # take properties starting with Blocks and Lines ... but not ending with Specified
    coverage_info = ( [(k, int( obj.__getattribute__(k))) for k in props if not k == "Lines" and  k.startswith("Lines") and not k.endswith("Specified")] + 
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

    import argparse
    parser = argparse.ArgumentParser(description='Parses a VS *.coveragexml file and extract information about the coverage.')
    parser.add_argument('--methodanonymous', help='include methods whose name starts with <', action='store')
    parser.add_argument('--showignored', help='show items that are ignored', action='store')
    parser.add_argument('file_path', help='the file to load')
    args = parser.parse_args()

    # should be a CoverageXml.Xml.Model.CoverageDSPriv
    #deserialized = load_coverage_file(r"C:\Users\tdesodt\Desktop\TFSBuildUser_TFSBUILDCTRL1 2012-09-20 16_08_14_Any CPU_Release.coveragexml")
    deserialized = load_coverage_file(args.file_path)


    print "%s source files" % deserialized.SourceFiles.Count

    for i, analyzed_module in enumerate( deserialized.Modules):
        print "- ", i, " ", analyzed_module.ModuleName

        #for infoTuple in extract_coverage_info(analyzed_module).items():
        #    print "\t%s :\t%s" % (infoTuple)

        for j, namespace in enumerate(analyzed_module.Namespaces):
            print "\t- ", j, " ", namespace.NamespaceName
            #for infoTuple in extract_coverage_info(namespace).items():
            #    print "\t\t%s :\t%s" % (infoTuple)

            for k, the_class in enumerate(namespace.Classes):
                print "\t\t- ", k, " ", the_class.ClassName
                #for infoTuple in extract_coverage_info(the_class).items():
                #    print "\t\t\t%s :\t%s" % (infoTuple)

                for m, the_method in enumerate(the_class.Methods):
                    if args.methodanonymous or ( not the_method.MethodName.strip().startswith("<")):
                        print "\t\t\t- ", m, " ", the_method.MethodName
                        for infoTuple in extract_coverage_info(the_method).items():
                            print "\t\t\t\t%s :\t%s" % (infoTuple)
                    elif args.showignored:
                        print "(ignored %s )" % the_method.MethodName

    raw_input("press any key to continue or whatever ...")

#trick to run only directly, not when imported as a module...
if __name__ == "__main__":
    main()