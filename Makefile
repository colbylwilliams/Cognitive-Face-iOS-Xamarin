
all : clean ./Binding/ProjectOxfordFace.framework


./Sharpie/Binding/ProjectOxfordFace.framework :
	mkdir -p Sharpie
	-cd Sharpie && sharpie pod init iphoneos ProjectOxfordFace
	-cd Sharpie && sharpie pod bind


./Binding/ProjectOxfordFace.framework : ./Sharpie/Binding/ProjectOxfordFace.framework
	-mv ./Sharpie/Binding ./
	rm -rf Sharpie


clean :
	rm -rf Sharpie