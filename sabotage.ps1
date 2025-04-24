# sabotage.ps1
$REPO_PATH = "C:\Users\Alsfine\dev work\PhoneAppDesignPatterns"
$LOG_FILE = "$REPO_PATH\sabotage.log"

cd $REPO_PATH

# 1. Delete random file
$TARGET_FILE = Get-ChildItem -Recurse -File -Exclude ".git/*" | Get-Random -Count 1
Remove-Item $TARGET_FILE.FullName -Verbose *>> $LOG_FILE

# 2. Create merge conflict
git checkout -b "sabotage-$(Get-Date -Format 'yyyyMMddHHmmss')" *>> $LOG_FILE
Add-Content -Path "main.cs" -Value "// SABOTAGE: $(Get-Date)" *>> $LOG_FILE
git commit -am "CHAOS: Fake changes $(Get-Date)" *>> $LOG_FILE
git checkout main *>> $LOG_FILE
Add-Content -Path "main.cs" -Value "// COUNTER-SABOTAGE: $(Get-Date)" *>> $LOG_FILE
git commit -am "ORDER: Counter-fake changes $(Get-Date)" *>> $LOG_FILE
git merge HEAD@{1} *>> $LOG_FILE  # Force conflict

# 3. Log the carnage
"🔥 SABOTAGE COMPLETE AT $(Get-Date)" *>> $LOG_FILE
