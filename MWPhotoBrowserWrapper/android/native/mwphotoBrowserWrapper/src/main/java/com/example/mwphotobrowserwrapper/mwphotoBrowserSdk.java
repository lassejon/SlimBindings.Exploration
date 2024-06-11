package com.example.mwphotobrowserwrapper;

public class MWPhotoBrowserSdk {
    public static String getPhotoPath(int index) {
        return "file:///android_asset/" + index + ".jpg";
    }
}
