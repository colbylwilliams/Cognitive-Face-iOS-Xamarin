XCODEBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild

CONFIGURATION=Release
PROJECT=Pods.xcodeproj
TARGET=ProjectOxfordFace
FRAMEWORK=$(TARGET).framework


all : clean ./Binding/$(FRAMEWORK)


./Sharpie/Pods/$(PROJECT) :
	mkdir -p Sharpie
	cd Sharpie && sharpie pod init -f iphoneos $(TARGET)


./Sharpie/$(CONFIGURATION)-iphoneos/$(TARGET)/$(FRAMEWORK) : ./Sharpie/Pods/$(PROJECT)
	cd Sharpie/Pods && $(XCODEBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration $(CONFIGURATION) clean build
	-mv Sharpie/build/$(CONFIGURATION)-iphoneos Sharpie/


./Sharpie/$(CONFIGURATION)-iphonesimulator/$(TARGET)/$(FRAMEWORK) : ./Sharpie/$(CONFIGURATION)-iphoneos/$(TARGET)/$(FRAMEWORK)
	cd Sharpie/Pods && $(XCODEBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration $(CONFIGURATION) clean build
	-mv Sharpie/build/$(CONFIGURATION)-iphonesimulator Sharpie/


./Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK) : ./Sharpie/$(CONFIGURATION)-iphonesimulator/$(TARGET)/$(FRAMEWORK)
	mkdir -p Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK)
	cp -r Sharpie/$(CONFIGURATION)-iphoneos/$(TARGET)/$(FRAMEWORK)/. Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK)
	lipo Sharpie/$(CONFIGURATION)-iphonesimulator/$(TARGET)/$(FRAMEWORK)/$(TARGET) Sharpie/$(CONFIGURATION)-iphoneos/$(TARGET)/$(FRAMEWORK)/$(TARGET) -create -output Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK)/$(TARGET)


./Binding/$(FRAMEWORK) : ./Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK)
	mkdir -p Binding
	-mv ./Sharpie/$(CONFIGURATION)-iphoneuniversal/$(FRAMEWORK) ./Binding


clean :
	rm -rf Sharpie
	rm -rf Binding