# Windows Form RingCentral OAuth Demo


## Video Demo

For how this demo works, please watch [this vide](./video.mp4).

## Setup

### Configuration

Update your RingCentral app, add `https://does-not-exist.com` as redirect uri.

Why `https://does-not-exist.com`? The redirect uri doesn't matter, it could be whatever. Please read the code for more detail.


### Edit code to specify `clientId` & `clientSecret`

Please edit [this line](./WindowsFormsApp1/OAuthForm.cs#17) to specify `clientId` & `clientSecret`
