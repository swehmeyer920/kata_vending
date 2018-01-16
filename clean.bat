msbuild kata_vending.sln /t:Clean
msbuild kata_vending.sln /t:Clean /p:Configuration=Release
rmdir /s /q TestResults
del /q "kata_vendingTests\obj\Debug\*.*"
rmdir /s /q kata_vending\obj
rmdir /s /q kata_vendingTests\obj

