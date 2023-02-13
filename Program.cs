using ID;

FileReader reader = new FileReader();
FileWrite write = new FileWrite();
Filter filter = new Filter();

String directory = Environment.CurrentDirectory;
List<ID.ID> idNumbers = reader.read(directory + "/ID.txt");
List<ID.ID> bornAfter2010 = filter.afterYear(idNumbers, 2010);
List<ID.ID> bornBefore2010 = filter.beforeYear(idNumbers, 2010);

String content = "Number of people born before 2010: " + bornBefore2010.Count() +
                 "\nNumber of people born after 2010: " + bornAfter2010.Count();

write.write(directory + "/report.txt", content);
