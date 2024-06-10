//
//  OriginalNativeSwiftFramework.swift
//  OriginalNativeSwiftFramework
//
//  Created by Lasse Jon Marqaurdt Frederiksen on 28/05/2024.
//

import Foundation

@objc(Original)
public class Original : NSObject {
    
    @objc(mulityply)
    public static func mulityply() -> String {
        let multiplier: String = "6";
        return multiplier;
    }
}
