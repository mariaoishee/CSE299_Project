using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventController
{
    internal class Email
    {

        public static string sendWelcome()
        {
            return @"<!DOCTYPE html>
                        <html>
                        <head>
                            <style>
                                body {
                                    font-family: Arial, sans-serif;
                                    background-color: #f2f2f2;
                                    padding: 20px;
                                }
                                .email-container {
                                    max-width: 600px;
                                    margin: 0 auto;
                                    background-color: #ffffff;
                                    border-radius: 8px;
                                    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
                                }
                                .header {
                                    background-color: #e74c3c;
                                    color: #ffffff;
                                    padding: 20px;
                                    border-top-left-radius: 8px;
                                    border-top-right-radius: 8px;
                                }
                                .header h1 {
                                    margin: 0;
                                }
                                .content {
                                    padding: 20px;
                                }
                                .footer {
                                    background-color: #f2f2f2;
                                    padding: 10px;
                                    text-align: center;
                                    border-bottom-left-radius: 8px;
                                    border-bottom-right-radius: 8px;
                                }
                            </style>
                        </head>
                        <body>
                            <div class=""email-container"">
                                <div class=""header"">
                                    <h1>Welcome to BPL Event Controller</h1>
                                    <p>Your Gateway to Managing the BPL Bidding Event</p>
                                </div>
                                <div class=""content"">
                                    <h2>Hello Manager,</h2>
                                    <p>We are thrilled to present the BPL Sports Bidding Program, where player all over the world will be selected by our local BPL teams and you'll get to see the bitter rivalry among the teams unveil</p>
                                    <p>You are given this uniue opportunity to be a part of the dashboard projection system who will be in control of the whole event's projection screen. Whatever you do in your dashboard will be updated 
                                    in the projection screen for everyone to get immersed into.</p>
                                    
                                    <p>Prepare to immerse yourself in the world of BPL sports bidding!</p>
                                    <p>Stay tuned for the official launch date and more program details.</p>
                                    <p>Best regards,</p>
                                    <p>The BPL Sports Bidding Team</p>
                                </div>
                                <div class=""footer"">
                                    <p>&copy; 2023 BPL Sports Bidding Program. All rights reserved.</p>
                                </div>
                            </div>
                        </body>
                        </html>
                        ";
        }

    }
}
