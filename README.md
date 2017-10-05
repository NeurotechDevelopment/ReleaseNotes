# ReleaseNotes editor
This application uses visual studio git tfs Rest API to help extracting commit comments based on branches differences.

An editor is provided to manually improve comments, select or deselect them before exporting these to a ReleaseNotes.md file.

Initial idea for the app occured when management wanted to have release notes per release branch.
Yet such documentation was missing. Somehow I needed to get commits for each release branch.

The usage flow of this program is that you first select repository, than a branch you want to get commits from and the branch(es)
to exclude commits from. For example we want commits for branch r_6.3.0. Because branches contain all the history of commits from
any earlier branches, we want to exclude commits from them. So you would select r_6.3.0 as a source branch and exclude r_6.2.0 branch.
After that a list of "delta" is opened in an editor.

After editing them you can finally save these as ReleaseNotes documentation file.

Nice and simple.
