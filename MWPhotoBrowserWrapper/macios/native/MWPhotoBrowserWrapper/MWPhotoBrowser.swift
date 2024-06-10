//
//  MWPhotoBrowserWrapperImpl.swift
//  MWPhotoBrowserWrapper
//
//  Created by Lasse Jon Marqaurdt Frederiksen on 28/05/2024.
//

import Foundation
import SwiftyJSON

@objc(MWPhotoBrowser)
public class MWPhotoBrowser: NSObject {
    @objc public static func itemCount() -> Int {
            let urlString = "https://jsonplaceholder.typicode.com/posts" // Example URL that returns a list of posts
            guard let url = URL(string: urlString) else {
                NSLog("Invalid URL")
                return 0
            }
            
            var itemCount = 0
            let semaphore = DispatchSemaphore(value: 0)
            
            let task = URLSession.shared.dataTask(with: url) { data, response, error in
                defer { semaphore.signal() }
                
                if let error = error {
                    NSLog("Error: \(error.localizedDescription)")
                    return
                }
                
                guard let data = data else {
                    print("No data received")
                    return
                }
                
                do {
                    let json = try JSON(data: data)
                    itemCount = json.array?.count ?? 0
                } catch {
                    NSLog("JSON parsing error: \(error.localizedDescription)")
                }
            }
            
            task.resume()
            semaphore.wait()
            
            return itemCount
        }
}


