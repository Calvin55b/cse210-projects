using System;

Job job1 = new Job();

job1._jobTitle = "Software Engineer";

job1._company = "Microsoft";

job1._startYear = 2019;

job1._endYear = 2020;

Job job2 = new Job();

job2._jobTitle = "Web Development";

job2._company = "Nvidia";

job2._startYear = 2000;

job2._endYear = 2011;



Resume jobResume = new Resume();

jobResume._personsName = "Billbo Baggins";

jobResume._job.Add(job1);

jobResume._job.Add(job2);



jobResume.Display();