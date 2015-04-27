# FTPushy
**FTP Atomic Upload Pusher**! In other words, a program to make it possible to upload web application updates in a temporary cloned folder, and then set a command to update all the new uploaded files to the production folder programmatically.

## What is the problem?
This tiny software made for Windows servers. Particularly, to address FTP and IIS issue for updating a website. The problem is, when you have to update your website, you need to upload changed files separately. For example, you need to upload a .css file, then your ASP.NET compiled dll, in advanced to several other files. So, your website may break while the upload progress is running by you. You are uploading one by one. A css is updated, however images are not yet! Now, just consider another case, while you are uploading a large DLL, or css file, a network interrupt may ruin your website.

## How FTPushy has solved that?
You would be able to create a temp folder, and upload intended files within this folder using FTP. When you are finished, you need to upload an emtpy file, named **go.txt**, so FTPushy will start to move all the files and folders within the temp folder to the production folder in a second.
So, all your production files will be updated at a glance!

## How to setup?
FTPushy is a standalone Windows application. You need to run and configure it in your web server. It will be configured simply within the interface by asking for two paths:

1. Source Path
2. Destination Path

## How to use?
FTPushy is made with a principle in mind: Do everything just by using a FTP client. So, after setting up the application, you no longer need to do a remote desktop (Of course, if you want to do a remote desktop all the time, you could manually copy them. This app is made to accelerate, and it will do it!). Just upload your files in the defined **temp** folder, and upload **go.txt** to trigger the move. That's it.

For example, you have already configured the app with the following folders:

Source: `c:\www\_temp`

Destination: `c:\www`


Now, you can upload **MyCode.dll** in `c:\www\_temp\bin`, and then upload `go.txt` in `c:\www\_temp\go.txt` when upload is finished. Now, FTPushy will detect `go.txt` and it would immediately copy all files and folders from `c:\www\_temp\*` to `c:\www\*`.


## Commands

1. `go.txt`: Go! Move all the uploaded files from temp to production, and clean the temp.
2. `clone.txt`: Clone all production folders (without files) in temp folder.

Note 1: This command files content is not important. If they become available with this name in the root of your defined `\_temp` folder, it would be all.
