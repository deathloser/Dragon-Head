package controllers;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.io.IOException;
import java.net.*;

@RestController
public class UrlCheckController {

    private final String siteIsUp = "Site is up!";
    private final String siteIsDown = "Site is down!";
    private final String incorrectUrl = "URL is incorrect!";

    @GetMapping("/check")
    public String getUrlStatusMessage(@RequestParam String url) {
        String returnMessage = "";
        try {
            URL urlObj = new URL(url);
            HttpURLConnection conn = (HttpURLConnection) urlObj.openConnection();
            conn.setRequestMethod("GET");
            conn.connect();
            //31:42
        } catch (MalformedURLException e) {
            returnMessage = incorrectUrl;

        } catch (IOException e) {
            // TODO Auto-generated catch block
            returnMessage = siteIsDown;
        }


        return returnMessage;

    }
    
}
