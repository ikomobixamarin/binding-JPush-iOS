# JPush SDK Xamarin.iOS binding

## Limitations

The native library .a provided by JPush does not contain any i386 cpu architecture data.
Since XCode 8.3.3, any Xamarin.iOS project referencing this library will fail to compile on the emulator.
Works fine on XCode 8.3.2

The library still works fine when building directly to an iPhone.