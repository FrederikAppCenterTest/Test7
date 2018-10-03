echo "Found NUnit test projects:"
find $APPCENTER_SOURCE_DIRECTORY -regex '.*Test.*\.csproj' -exec echo {} \;