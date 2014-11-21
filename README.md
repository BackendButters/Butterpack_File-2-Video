File2Video
==========

Store any file in a video or image.
This program was intended to store any file as a video or still image that could be uploaded to YouTube, Imageshack etc., downloaded by someone else and unpacked to the original file. 
Since I'm experiencing a serious lack of time, I won't be able to continue work on this project. Therefore, I open sourced it here so maybe it can be useful for someone. 
Currently, an image creation of a file is possible with the option to encrypt the file. A reverse transformation is also possible. Please note, that the algorithm is not yet equipped with a kickass error correction, so if the image is compressed, the original data will be lost. 
I started to implement GIF output types but that's not yet done. Also, video creation has to be done, a losless format is necessary. 
This project uses the AForge and NReco FFMPEG library.
Built with Microsoft Visual Studio 2013.

Also, check out the [C++ Port!](https://github.com/jpzk/butterpack "C++ Port")