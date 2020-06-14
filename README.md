### Janda.Runtime.Assembly

| master | develop |
|:------:|:-----------:|
|[![Build Status](http://nas:8081/buildStatus/icon?job=Janda.Runtime.Assembly/master)](http://nas:8081/job/Janda.Runtime.Assembly/job/master)|[![Build Status](http://nas:8081/buildStatus/icon?job=Janda.Runtime.Assembly/develop)](http://nas:8081/job/Janda.Runtime.Assembly/job/develop)|





### Add assembly logging

Use ```AddAssemblyLogger``` extension method to add assembly logger to the service collection:

```
serviceCollection.AddAssemblyLogger(LogLevel.Information)
```



### Start assembly logging

To start logging inject ```IAssemblyLogger``` into the main application constructor:

```
   public App(IAssemblyLogger _)
```



### Logging output

```
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Format.Retrospect.Structures", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Device.Sequential.DeviceBuffer", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Device.Sequential.Abstractions", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Device.Sequential.TapeImage", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Backup.Target.FileSystem", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Backup.Target.Common", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Backup.Common.Files", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Device.Sequential.DeviceReader", "Version": "1.0.0"}}
[09:08:27 INF] Running Janda.Format.Retrospect.App 1.1.0-alpha.57 Retrospect format test application
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Device.Sequential.TapeImage.Reader", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Format.Retrospect.Readers", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Backup.Sequential", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Telemetry.Capacity", "Version": "1.0.0"}}
[09:08:27 INF] Reading T001...
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Parsers.Text", "Version": "1.0.0"}}
[09:08:27 INF] Loaded {"assembly": {"Name": "Janda.Parsers.DateTime", "Version": "1.1.0"}}
```

