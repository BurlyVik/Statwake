# Statwake
This program acts as a real-time save file monitor and stats overlay for Elden Ring.

It watches your save data in the background so you can see player details like your character name, level, playtime, and death count inside a lightweight custom overlay window on your screen. Whenever the game updates your save file, the program catches the change automatically, reads the fresh values every couple of seconds, and updates your stats on the fly without needing you to pause or tab out of the game.

Start by selecting browse to locate your Elden Save path. By default browse initial directory is set to %APPDATA%\Elden Ring

<img width="329" height="666" alt="image" src="https://github.com/user-attachments/assets/174985b6-0c29-4c60-bc04-555f19d78bd7" />

You can show the the log to what profiles have been loaded, but the Profile box will contain the slot data.

<img width="989" height="634" alt="image" src="https://github.com/user-attachments/assets/839fe85f-9a1c-4e53-ad08-17df483b9017" />

Click the Show/Hide to open/hide the overlay.

<img width="485" height="51" alt="image" src="https://github.com/user-attachments/assets/f2d2f582-5b4c-42ae-80e1-bd4c56c24449" />

To change the label colors, right + click the labels on Overlay and select a color. This can be done for all labels on the Overlay.

<img width="495" height="348" alt="image" src="https://github.com/user-attachments/assets/6669effa-87f7-4766-9b58-4566a26c5bfb" />

To move the color-wheel, hold shift and left mouse-click. For every label color change the wheel is reset, best if chosen from its default location. And to hide the color wheel, just right+click the wheel.

<img width="681" height="679" alt="explorer_ZSLmBGfijr" src="https://github.com/user-attachments/assets/6cb00353-28ae-404d-b3ef-b9a2035824af" />

You may move the Overlay form from the dark shaded area. 

<img width="847" height="274" alt="firefox_hks5N9tsLY" src="https://github.com/user-attachments/assets/10fab7bf-7107-4b82-bb60-2dabce8e10dd" />

Bounds detection will appear as green scan-lines when within snap-range (_50px from bounds edges_)

<img width="640" height="501" alt="explorer_5y5adFfmJY" src="https://github.com/user-attachments/assets/c5ea5f4a-4336-45af-ba84-12472925557c" />

Adjust transparency of the form with Ctrl+Wheel Mouse

<img width="720" height="219" alt="2FdqsqhCAb" src="https://github.com/user-attachments/assets/d18c58ef-c751-4bc0-b68f-2e18954bf7d2" />

Both save file and color changing labels will be saved into a config file for later reloading.

<img width="514" height="248" alt="image" src="https://github.com/user-attachments/assets/57f61647-b646-4315-b27e-b154a0acc8bd" />

You may also change which profile to monitor during gameplay, since the program is just "checking" the file, there is no hold or lock preventing you from cycling slots. Helps when playing a different character while game is running.

**Note**: There may be instances where the file monitor may not check often, this is a slight bug I am trying to address, but the death counter is rather flawless.

Disclaimer: Use Statwake at your own risk. I am not responsible for any bans, restrictions, or issues that may arise from using this program. I have tested it personally with EAC for nearly two weeks without any trouble, but if you have concerns regarding Easy Anti-Cheat, you are under no obligation to use this tool. Feel free to research how to disable EAC on your own system if you choose to proceed.
