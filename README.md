# Windows Form RingCentral OAuth Demo

## Disclaimer

This project is provided as is. It is by no means the best practice.


## Video Demo

For how this demo works, please watch [this video](./video.mp4).

## Setup

### Configuration

Update your RingCentral app, add `https://does-not-exist.com` as redirect uri.

Why `https://does-not-exist.com`? The redirect uri doesn't matter, it could be whatever. Please read the code for more detail.


### Edit code to specify `clientId` & `clientSecret`

Please edit [this line](./WindowsFormsApp1/OAuthForm.cs#L17) to specify `clientId` & `clientSecret`.


## About Login method

In the demo video, I was using "Single Sign On". It is not required to login via it. You can login RingCentral with whatever way that works best for you.
