# CloudStack.NET SDK Generator

The CloudStack.NET SDK Generator uses the source code of CloudStack to generate an SDK library, in a similar method to that used to generate the API documentation.

## Requirements

* Java 1.7
* Version of CloudStack, fully built from source.  All modules should be built, as only built modules are included in the generated SDK! 

### Building CloudStack from Source on Windows

Setting up the build environment for CloudStack under Windows is somewhat challenging.  It can be simpler to do all of this within a VM using vagrant:

1.  Open a command prompt and go to CloudStackBuild
1.  Build and start the VM: `vagrant up`
1.  SSH into the VM.  By default this will be on localhost:2222, but if you already had something there, vagrant may have picked a new port, and this will have been displayed when it started.  Username: vagrant, Password: vagrant.
1.  Check out the cloudstack code: `cd /vagrant && git clone https://github.com/apache/cloudstack.git`
1.  Switch the code to the release tag you want to generate the SDK for: `cd /vagrant/cloudstack && git checkout tags/4.7.0`
1.  Copy the dependencies locally: `cp /vagrant/deps/* /vagrant/cloudstack/deps/`
1.  Install the non-OSS dependencies: `cd /vagrant/cloudstack/deps && ./install-non-oss.sh` 
1.  Build Cloudstack: `cd /vagrant/cloudstack && mvn install -Pdeps,developer -Dnoredist -DskipTests=true`


## Instructions

1.  Build CloudStack