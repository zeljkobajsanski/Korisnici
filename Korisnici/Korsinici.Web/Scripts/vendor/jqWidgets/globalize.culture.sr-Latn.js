  


<!DOCTYPE html>
<html>
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# githubog: http://ogp.me/ns/fb/githubog#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>globalize/lib/cultures/globalize.culture.sr-Latn.js at master · jquery/globalize</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub" />
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub" />
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png" />
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png" />
    <link rel="logo" type="image/svg" href="http://github-media-downloads.s3.amazonaws.com/github-logo.svg" />
    <link rel="xhr-socket" href="/_sockets" />


    <meta name="msapplication-TileImage" content="/windows-tile.png" />
    <meta name="msapplication-TileColor" content="#ffffff" />
    <meta name="selected-link" value="repo_source" data-pjax-transient />

    
    
    <link rel="icon" type="image/x-icon" href="/favicon.ico" />

    <meta content="authenticity_token" name="csrf-param" />
<meta content="TbFYe+zQ9LwNK8KmLBWqu4XmQmncOdTV74mWV/O30Gs=" name="csrf-token" />

    <link href="https://a248.e.akamai.net/assets.github.com/assets/github-2bf871a9b64bd2274d95998848be29a48393d86b.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://a248.e.akamai.net/assets.github.com/assets/github2-21da5ae283333425ecbb508874c51e5413d9e300.css" media="all" rel="stylesheet" type="text/css" />
    


      <script src="https://a248.e.akamai.net/assets.github.com/assets/frameworks-92d138f450f2960501e28397a2f63b0f100590f0.js" type="text/javascript"></script>
      <script src="https://a248.e.akamai.net/assets.github.com/assets/github-cb4775af41c6df8a5a7a2399bb8399da5e4a94e2.js" type="text/javascript"></script>
      
      <meta http-equiv="x-pjax-version" content="f8f390cd9345c1672e882162ab08c46a">

        <link data-pjax-transient rel='permalink' href='/jquery/globalize/blob/1167900d313e829618502de28f07501e7da28caa/lib/cultures/globalize.culture.sr-Latn.js'>
    <meta property="og:title" content="globalize"/>
    <meta property="og:type" content="githubog:gitrepository"/>
    <meta property="og:url" content="https://github.com/jquery/globalize"/>
    <meta property="og:image" content="https://secure.gravatar.com/avatar/6906f317a4733f4379b06c32229ef02f?s=420&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png"/>
    <meta property="og:site_name" content="GitHub"/>
    <meta property="og:description" content="globalize - New age globalization and localization. Formats and parses strings, dates and numbers in over 350 cultures."/>
    <meta property="twitter:card" content="summary"/>
    <meta property="twitter:site" content="@GitHub">
    <meta property="twitter:title" content="jquery/globalize"/>

    <meta name="description" content="globalize - New age globalization and localization. Formats and parses strings, dates and numbers in over 350 cultures." />

  <link href="https://github.com/jquery/globalize/commits/master.atom" rel="alternate" title="Recent Commits to globalize:master" type="application/atom+xml" />

  </head>


  <body class="logged_in page-blob windows vis-public env-production  ">
    <div id="wrapper">

      

      
      
      

      <div class="header header-logged-in true">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/">
  <span class="mega-icon mega-icon-invertocat"></span>
</a>

    <div class="divider-vertical"></div>

      <a href="/notifications" class="notification-indicator tooltipped downwards" title="You have no unread notifications">
    <span class="mail-status all-read"></span>
  </a>
  <div class="divider-vertical"></div>


      <div class="command-bar js-command-bar  in-repository">
          <form accept-charset="UTF-8" action="/search" class="command-bar-form" id="top_search_form" method="get">
  <a href="/search/advanced" class="advanced-search-icon tooltipped downwards command-bar-search" id="advanced_search" title="Advanced search"><span class="mini-icon mini-icon-advanced-search "></span></a>

  <input type="text" data-hotkey="/ s" name="q" id="js-command-bar-field" placeholder="Search or type a command" tabindex="1" data-username="zeljkobajsanski" autocapitalize="off">

    <input type="hidden" name="nwo" value="jquery/globalize" />

    <div class="select-menu js-menu-container js-select-menu search-context-select-menu">
      <span class="minibutton select-menu-button js-menu-target">
        <span class="js-select-button">This repository</span>
      </span>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container">
        <div class="select-menu-modal">

          <div class="select-menu-item js-navigation-item selected">
            <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
            <input type="radio" name="search_target" value="repository" checked="checked" />
            <div class="select-menu-item-text js-select-button-text">This repository</div>
          </div> <!-- /.select-menu-item -->

          <div class="select-menu-item js-navigation-item">
            <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
            <input type="radio" name="search_target" value="global" />
            <div class="select-menu-item-text js-select-button-text">All repositories</div>
          </div> <!-- /.select-menu-item -->

        </div>
      </div>
    </div>

  <span class="mini-icon help tooltipped downwards" title="Show command bar help">
    <span class="mini-icon mini-icon-help"></span>
  </span>

    <input type="hidden" name="type" value="Code" />

  <input type="hidden" name="ref" value="cmdform">

  <div class="divider-vertical"></div>

    <input type="hidden" class="js-repository-name-with-owner" value="jquery/globalize"/>
    <input type="hidden" class="js-repository-branch" value="master"/>
    <input type="hidden" class="js-repository-tree-sha" value="82851d2d7b3fb42762a46286ff714edcfdb855d4"/>
</form>
        <ul class="top-nav">
            <li class="explore"><a href="https://github.com/explore">Explore</a></li>
            <li><a href="https://gist.github.com">Gist</a></li>
            <li><a href="/blog">Blog</a></li>
          <li><a href="http://help.github.com">Help</a></li>
        </ul>
      </div>

    

  

    <ul id="user-links">
      <li>
        <a href="https://github.com/zeljkobajsanski" class="name">
          <img height="20" src="https://secure.gravatar.com/avatar/30afc4ef4ec4c3f62c808d7de8bb6ef9?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /> zeljkobajsanski
        </a>
      </li>

        <li>
          <a href="/new" id="new_repo" class="tooltipped downwards" title="Create a new repo">
            <span class="mini-icon mini-icon-create"></span>
          </a>
        </li>

        <li>
          <a href="/settings/profile" id="account_settings"
            class="tooltipped downwards"
            title="Account settings ">
            <span class="mini-icon mini-icon-account-settings"></span>
          </a>
        </li>
        <li>
          <a class="tooltipped downwards" href="/logout" data-method="post" id="logout" title="Sign out">
            <span class="mini-icon mini-icon-logout"></span>
          </a>
        </li>

    </ul>


<div class="js-new-dropdown-contents hidden">
  <ul class="dropdown-menu">
    <li>
      <a href="/new"><span class="mini-icon mini-icon-create"></span> New repository</a>
    </li>
    <li>
        <a href="https://github.com/jquery/globalize/issues/new"><span class="mini-icon mini-icon-issue-opened"></span> New issue</a>
    </li>
    <li>
    </li>
    <li>
      <a href="/organizations/new"><span class="mini-icon mini-icon-u-list"></span> New organization</a>
    </li>
  </ul>
</div>


    
  </div>
</div>

      

      

      


            <div class="site hfeed" itemscope itemtype="http://schema.org/WebPage">
      <div class="hentry">
        
        <div class="pagehead repohead instapaper_ignore readability-menu ">
          <div class="container">
            <div class="title-actions-bar">
              

<ul class="pagehead-actions">


    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="authenticity_token" type="hidden" value="TbFYe+zQ9LwNK8KmLBWqu4XmQmncOdTV74mWV/O30Gs=" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="946945" />

    <div class="select-menu js-menu-container js-select-menu">
      <span class="minibutton select-menu-button js-menu-target">
        <span class="js-select-button">
          <span class="mini-icon mini-icon-watching"></span>
          Watch
        </span>
      </span>

      <div class="select-menu-modal-holder js-menu-content">
        <div class="select-menu-modal">
          <div class="select-menu-header">
            <span class="select-menu-title">Notification status</span>
            <span class="mini-icon mini-icon-remove-close js-menu-close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container">

            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">You only receive notifications for discussions in which you participate or are @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="mini-icon mini-icon-watching"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
              <div class="select-menu-item-text">
                <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">You receive notifications for all discussions in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="mini-icon mini-icon-unwatch"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">You do not receive any notifications for discussions in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="mini-icon mini-icon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

    <li class="js-toggler-container js-social-container starring-container ">
      <a href="/jquery/globalize/unstar" class="minibutton js-toggler-target star-button starred upwards" title="Unstar this repo" data-remote="true" data-method="post" rel="nofollow">
        <span class="mini-icon mini-icon-remove-star"></span>
        <span class="text">Unstar</span>
      </a>
      <a href="/jquery/globalize/star" class="minibutton js-toggler-target star-button unstarred upwards" title="Star this repo" data-remote="true" data-method="post" rel="nofollow">
        <span class="mini-icon mini-icon-star"></span>
        <span class="text">Star</span>
      </a>
      <a class="social-count js-social-count" href="/jquery/globalize/stargazers">938</a>
    </li>

        <li>
          <a href="/jquery/globalize/fork" class="minibutton js-toggler-target fork-button lighter upwards" title="Fork this repo" rel="nofollow" data-method="post">
            <span class="mini-icon mini-icon-branch-create"></span>
            <span class="text">Fork</span>
          </a>
          <a href="/jquery/globalize/network" class="social-count">159</a>
        </li>


</ul>

              <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
                <span class="repo-label"><span>public</span></span>
                <span class="mega-icon mega-icon-public-repo"></span>
                <span class="author vcard">
                  <a href="/jquery" class="url fn" itemprop="url" rel="author">
                  <span itemprop="title">jquery</span>
                  </a></span> /
                <strong><a href="/jquery/globalize" class="js-current-repository">globalize</a></strong>
              </h1>
            </div>

            
  <ul class="tabs">
    <li class="pulse-nav"><a href="/jquery/globalize/pulse" class="js-selected-navigation-item " data-selected-links="pulse /jquery/globalize/pulse" rel="nofollow"><span class="mini-icon mini-icon-pulse"></span></a></li>
    <li><a href="/jquery/globalize" class="js-selected-navigation-item selected" data-selected-links="repo_source repo_downloads repo_commits repo_tags repo_branches /jquery/globalize">Code</a></li>
    <li><a href="/jquery/globalize/network" class="js-selected-navigation-item " data-selected-links="repo_network /jquery/globalize/network">Network</a></li>
    <li><a href="/jquery/globalize/pulls" class="js-selected-navigation-item " data-selected-links="repo_pulls /jquery/globalize/pulls">Pull Requests <span class='counter'>9</span></a></li>

      <li><a href="/jquery/globalize/issues" class="js-selected-navigation-item " data-selected-links="repo_issues /jquery/globalize/issues">Issues <span class='counter'>57</span></a></li>

      <li><a href="/jquery/globalize/wiki" class="js-selected-navigation-item " data-selected-links="repo_wiki /jquery/globalize/wiki">Wiki</a></li>


    <li><a href="/jquery/globalize/graphs" class="js-selected-navigation-item " data-selected-links="repo_graphs repo_contributors /jquery/globalize/graphs">Graphs</a></li>


  </ul>
  
<div class="tabnav">

  <span class="tabnav-right">
    <ul class="tabnav-tabs">
          <li><a href="/jquery/globalize/tags" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_tags /jquery/globalize/tags">Tags <span class="counter ">3</span></a></li>
    </ul>
  </span>

  <div class="tabnav-widget scope">


    <div class="select-menu js-menu-container js-select-menu js-branch-menu">
      <a class="minibutton select-menu-button js-menu-target" data-hotkey="w" data-ref="master">
        <span class="mini-icon mini-icon-branch"></span>
        <i>branch:</i>
        <span class="js-select-button">master</span>
      </a>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container">

        <div class="select-menu-modal">
          <div class="select-menu-header">
            <span class="select-menu-title">Switch branches/tags</span>
            <span class="mini-icon mini-icon-remove-close js-menu-close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-filters">
            <div class="select-menu-text-filter">
              <input type="text" id="commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
            </div>
            <div class="select-menu-tabs">
              <ul>
                <li class="select-menu-tab">
                  <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
                </li>
                <li class="select-menu-tab">
                  <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
                </li>
              </ul>
            </div><!-- /.select-menu-tabs -->
          </div><!-- /.select-menu-filters -->

          <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket css-truncate" data-tab-filter="branches">

            <div data-filterable-for="commitish-filter-field" data-filterable-type="substring">

                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/gh-pages/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="gh-pages" rel="nofollow" title="gh-pages">gh-pages</a>
                </div> <!-- /.select-menu-item -->
                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/jquery-global/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="jquery-global" rel="nofollow" title="jquery-global">jquery-global</a>
                </div> <!-- /.select-menu-item -->
                <div class="select-menu-item js-navigation-item selected">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/master/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="master" rel="nofollow" title="master">master</a>
                </div> <!-- /.select-menu-item -->
            </div>

              <div class="select-menu-no-results">Nothing to show</div>
          </div> <!-- /.select-menu-list -->


          <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket css-truncate" data-tab-filter="tags">
            <div data-filterable-for="commitish-filter-field" data-filterable-type="substring">

                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/v0.1.1/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="v0.1.1" rel="nofollow" title="v0.1.1">v0.1.1</a>
                </div> <!-- /.select-menu-item -->
                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/v0.1.0a2/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="v0.1.0a2" rel="nofollow" title="v0.1.0a2">v0.1.0a2</a>
                </div> <!-- /.select-menu-item -->
                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon mini-icon mini-icon-confirm"></span>
                  <a href="/jquery/globalize/blob/v0.1.0a1/lib/cultures/globalize.culture.sr-Latn.js" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="v0.1.0a1" rel="nofollow" title="v0.1.0a1">v0.1.0a1</a>
                </div> <!-- /.select-menu-item -->
            </div>

            <div class="select-menu-no-results">Nothing to show</div>

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

  </div> <!-- /.scope -->

  <ul class="tabnav-tabs">
    <li><a href="/jquery/globalize" class="selected js-selected-navigation-item tabnav-tab" data-selected-links="repo_source /jquery/globalize">Files</a></li>
    <li><a href="/jquery/globalize/commits/master" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_commits /jquery/globalize/commits/master">Commits</a></li>
    <li><a href="/jquery/globalize/branches" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_branches /jquery/globalize/branches" rel="nofollow">Branches <span class="counter ">3</span></a></li>
  </ul>

</div>

  
  
  


            
          </div>
        </div><!-- /.repohead -->

        <div id="js-repo-pjax-container" class="container context-loader-container" data-pjax-container>
          


<!-- blob contrib key: blob_contributors:v21:700fbd964e5875c0d2b291a1055d0f53 -->
<!-- blob contrib frag key: views10/v8/blob_contributors:v21:700fbd964e5875c0d2b291a1055d0f53 -->


<div id="slider">
    <div class="frame-meta">

      <p title="This is a placeholder element" class="js-history-link-replace hidden"></p>

        <div class="breadcrumb">
          <span class='bold'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/jquery/globalize" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">globalize</span></a></span></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/jquery/globalize/tree/master/lib" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">lib</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/jquery/globalize/tree/master/lib/cultures" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">cultures</span></a></span><span class="separator"> / </span><strong class="final-path">globalize.culture.sr-Latn.js</strong> <span class="js-zeroclipboard zeroclipboard-button" data-clipboard-text="lib/cultures/globalize.culture.sr-Latn.js" data-copied-hint="copied!" title="copy to clipboard"><span class="mini-icon mini-icon-clipboard"></span></span>
        </div>

      <a href="/jquery/globalize/find/master" class="js-slide-to" data-hotkey="t" style="display:none">Show File Finder</a>


        
  <div class="commit file-history-tease">
    <img class="main-avatar" height="24" src="https://secure.gravatar.com/avatar/d92ea7772f465256ad836de1ce642b37?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
    <span class="author"><a href="/rdworth" rel="author">rdworth</a></span>
    <time class="js-relative-date" datetime="2012-02-24T05:12:16-08:00" title="2012-02-24 05:12:16">February 24, 2012</time>
    <div class="commit-title">
        <a href="/jquery/globalize/commit/32b6db095f06c0bf6b10d251dcc0b2c83244d6cf" class="message">Added grunt with default lint and qunit tasks. Made some changes to p…</a>
    </div>

    <div class="participation">
      <p class="quickstat"><a href="#blob_contributors_box" rel="facebox"><strong>1</strong> contributor</a></p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2>Users on GitHub who have contributed to this file</h2>
      <ul class="facebox-user-list">
        <li>
          <img height="24" src="https://secure.gravatar.com/avatar/d92ea7772f465256ad836de1ce642b37?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
          <a href="/rdworth">rdworth</a>
        </li>
      </ul>
    </div>
  </div>


    </div><!-- ./.frame-meta -->

    <div class="frames">
      <div class="frame" data-permalink-url="/jquery/globalize/blob/1167900d313e829618502de28f07501e7da28caa/lib/cultures/globalize.culture.sr-Latn.js" data-title="globalize/lib/cultures/globalize.culture.sr-Latn.js at master · jquery/globalize · GitHub" data-type="blob">

        <div id="files" class="bubble">
          <div class="file">
            <div class="meta">
              <div class="info">
                <span class="icon"><b class="mini-icon mini-icon-text-file"></b></span>
                <span class="mode" title="File Mode">file</span>
                  <span>81 lines (75 sloc)</span>
                <span>1.858 kb</span>
              </div>
              <div class="actions">
                <div class="button-group">
                        <a class="minibutton tooltipped leftwards"
                           title="Clicking this button will automatically fork this project so you can edit the file"
                           href="/jquery/globalize/edit/master/lib/cultures/globalize.culture.sr-Latn.js"
                           data-method="post" rel="nofollow">Edit</a>
                  <a href="/jquery/globalize/raw/master/lib/cultures/globalize.culture.sr-Latn.js" class="button minibutton " id="raw-url">Raw</a>
                    <a href="/jquery/globalize/blame/master/lib/cultures/globalize.culture.sr-Latn.js" class="button minibutton ">Blame</a>
                  <a href="/jquery/globalize/commits/master/lib/cultures/globalize.culture.sr-Latn.js" class="button minibutton " rel="nofollow">History</a>
                </div><!-- /.button-group -->
              </div><!-- /.actions -->

            </div>
                <div class="blob-wrapper data type-javascript js-blob-data">
      <table class="file-code file-diff">
        <tr class="file-code-line">
          <td class="blob-line-nums">
            <span id="L1" rel="#L1">1</span>
<span id="L2" rel="#L2">2</span>
<span id="L3" rel="#L3">3</span>
<span id="L4" rel="#L4">4</span>
<span id="L5" rel="#L5">5</span>
<span id="L6" rel="#L6">6</span>
<span id="L7" rel="#L7">7</span>
<span id="L8" rel="#L8">8</span>
<span id="L9" rel="#L9">9</span>
<span id="L10" rel="#L10">10</span>
<span id="L11" rel="#L11">11</span>
<span id="L12" rel="#L12">12</span>
<span id="L13" rel="#L13">13</span>
<span id="L14" rel="#L14">14</span>
<span id="L15" rel="#L15">15</span>
<span id="L16" rel="#L16">16</span>
<span id="L17" rel="#L17">17</span>
<span id="L18" rel="#L18">18</span>
<span id="L19" rel="#L19">19</span>
<span id="L20" rel="#L20">20</span>
<span id="L21" rel="#L21">21</span>
<span id="L22" rel="#L22">22</span>
<span id="L23" rel="#L23">23</span>
<span id="L24" rel="#L24">24</span>
<span id="L25" rel="#L25">25</span>
<span id="L26" rel="#L26">26</span>
<span id="L27" rel="#L27">27</span>
<span id="L28" rel="#L28">28</span>
<span id="L29" rel="#L29">29</span>
<span id="L30" rel="#L30">30</span>
<span id="L31" rel="#L31">31</span>
<span id="L32" rel="#L32">32</span>
<span id="L33" rel="#L33">33</span>
<span id="L34" rel="#L34">34</span>
<span id="L35" rel="#L35">35</span>
<span id="L36" rel="#L36">36</span>
<span id="L37" rel="#L37">37</span>
<span id="L38" rel="#L38">38</span>
<span id="L39" rel="#L39">39</span>
<span id="L40" rel="#L40">40</span>
<span id="L41" rel="#L41">41</span>
<span id="L42" rel="#L42">42</span>
<span id="L43" rel="#L43">43</span>
<span id="L44" rel="#L44">44</span>
<span id="L45" rel="#L45">45</span>
<span id="L46" rel="#L46">46</span>
<span id="L47" rel="#L47">47</span>
<span id="L48" rel="#L48">48</span>
<span id="L49" rel="#L49">49</span>
<span id="L50" rel="#L50">50</span>
<span id="L51" rel="#L51">51</span>
<span id="L52" rel="#L52">52</span>
<span id="L53" rel="#L53">53</span>
<span id="L54" rel="#L54">54</span>
<span id="L55" rel="#L55">55</span>
<span id="L56" rel="#L56">56</span>
<span id="L57" rel="#L57">57</span>
<span id="L58" rel="#L58">58</span>
<span id="L59" rel="#L59">59</span>
<span id="L60" rel="#L60">60</span>
<span id="L61" rel="#L61">61</span>
<span id="L62" rel="#L62">62</span>
<span id="L63" rel="#L63">63</span>
<span id="L64" rel="#L64">64</span>
<span id="L65" rel="#L65">65</span>
<span id="L66" rel="#L66">66</span>
<span id="L67" rel="#L67">67</span>
<span id="L68" rel="#L68">68</span>
<span id="L69" rel="#L69">69</span>
<span id="L70" rel="#L70">70</span>
<span id="L71" rel="#L71">71</span>
<span id="L72" rel="#L72">72</span>
<span id="L73" rel="#L73">73</span>
<span id="L74" rel="#L74">74</span>
<span id="L75" rel="#L75">75</span>
<span id="L76" rel="#L76">76</span>
<span id="L77" rel="#L77">77</span>
<span id="L78" rel="#L78">78</span>
<span id="L79" rel="#L79">79</span>
<span id="L80" rel="#L80">80</span>

          </td>
          <td class="blob-line-code">
                  <div class="highlight"><pre><div class='line' id='LC1'><span class="cm">/*</span></div><div class='line' id='LC2'><span class="cm"> * Globalize Culture sr-Latn</span></div><div class='line' id='LC3'><span class="cm"> *</span></div><div class='line' id='LC4'><span class="cm"> * http://github.com/jquery/globalize</span></div><div class='line' id='LC5'><span class="cm"> *</span></div><div class='line' id='LC6'><span class="cm"> * Copyright Software Freedom Conservancy, Inc.</span></div><div class='line' id='LC7'><span class="cm"> * Dual licensed under the MIT or GPL Version 2 licenses.</span></div><div class='line' id='LC8'><span class="cm"> * http://jquery.org/license</span></div><div class='line' id='LC9'><span class="cm"> *</span></div><div class='line' id='LC10'><span class="cm"> * This file was generated by the Globalize Culture Generator</span></div><div class='line' id='LC11'><span class="cm"> * Translation: bugs found in this file need to be fixed in the generator</span></div><div class='line' id='LC12'><span class="cm"> */</span></div><div class='line' id='LC13'><br/></div><div class='line' id='LC14'><span class="p">(</span><span class="kd">function</span><span class="p">(</span> <span class="nb">window</span><span class="p">,</span> <span class="kc">undefined</span> <span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC15'><br/></div><div class='line' id='LC16'><span class="kd">var</span> <span class="nx">Globalize</span><span class="p">;</span></div><div class='line' id='LC17'><br/></div><div class='line' id='LC18'><span class="k">if</span> <span class="p">(</span> <span class="k">typeof</span> <span class="nx">require</span> <span class="o">!==</span> <span class="s2">&quot;undefined&quot;</span> <span class="o">&amp;&amp;</span></div><div class='line' id='LC19'>	<span class="k">typeof</span> <span class="nx">exports</span> <span class="o">!==</span> <span class="s2">&quot;undefined&quot;</span> <span class="o">&amp;&amp;</span></div><div class='line' id='LC20'>	<span class="k">typeof</span> <span class="nx">module</span> <span class="o">!==</span> <span class="s2">&quot;undefined&quot;</span> <span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC21'>	<span class="c1">// Assume CommonJS</span></div><div class='line' id='LC22'>	<span class="nx">Globalize</span> <span class="o">=</span> <span class="nx">require</span><span class="p">(</span> <span class="s2">&quot;globalize&quot;</span> <span class="p">);</span></div><div class='line' id='LC23'><span class="p">}</span> <span class="k">else</span> <span class="p">{</span></div><div class='line' id='LC24'>	<span class="c1">// Global variable</span></div><div class='line' id='LC25'>	<span class="nx">Globalize</span> <span class="o">=</span> <span class="nb">window</span><span class="p">.</span><span class="nx">Globalize</span><span class="p">;</span></div><div class='line' id='LC26'><span class="p">}</span></div><div class='line' id='LC27'><br/></div><div class='line' id='LC28'><span class="nx">Globalize</span><span class="p">.</span><span class="nx">addCultureInfo</span><span class="p">(</span> <span class="s2">&quot;sr-Latn&quot;</span><span class="p">,</span> <span class="s2">&quot;default&quot;</span><span class="p">,</span> <span class="p">{</span></div><div class='line' id='LC29'>	<span class="nx">name</span><span class="o">:</span> <span class="s2">&quot;sr-Latn&quot;</span><span class="p">,</span></div><div class='line' id='LC30'>	<span class="nx">englishName</span><span class="o">:</span> <span class="s2">&quot;Serbian (Latin)&quot;</span><span class="p">,</span></div><div class='line' id='LC31'>	<span class="nx">nativeName</span><span class="o">:</span> <span class="s2">&quot;srpski&quot;</span><span class="p">,</span></div><div class='line' id='LC32'>	<span class="nx">language</span><span class="o">:</span> <span class="s2">&quot;sr-Latn&quot;</span><span class="p">,</span></div><div class='line' id='LC33'>	<span class="nx">numberFormat</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC34'>		<span class="s2">&quot;,&quot;</span><span class="o">:</span> <span class="s2">&quot;.&quot;</span><span class="p">,</span></div><div class='line' id='LC35'>		<span class="s2">&quot;.&quot;</span><span class="o">:</span> <span class="s2">&quot;,&quot;</span><span class="p">,</span></div><div class='line' id='LC36'>		<span class="nx">negativeInfinity</span><span class="o">:</span> <span class="s2">&quot;-beskonačnost&quot;</span><span class="p">,</span></div><div class='line' id='LC37'>		<span class="nx">positiveInfinity</span><span class="o">:</span> <span class="s2">&quot;+beskonačnost&quot;</span><span class="p">,</span></div><div class='line' id='LC38'>		<span class="nx">percent</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC39'>			<span class="nx">pattern</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;-n%&quot;</span><span class="p">,</span><span class="s2">&quot;n%&quot;</span><span class="p">],</span></div><div class='line' id='LC40'>			<span class="s2">&quot;,&quot;</span><span class="o">:</span> <span class="s2">&quot;.&quot;</span><span class="p">,</span></div><div class='line' id='LC41'>			<span class="s2">&quot;.&quot;</span><span class="o">:</span> <span class="s2">&quot;,&quot;</span></div><div class='line' id='LC42'>		<span class="p">},</span></div><div class='line' id='LC43'>		<span class="nx">currency</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC44'>			<span class="nx">pattern</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;-n $&quot;</span><span class="p">,</span><span class="s2">&quot;n $&quot;</span><span class="p">],</span></div><div class='line' id='LC45'>			<span class="s2">&quot;,&quot;</span><span class="o">:</span> <span class="s2">&quot;.&quot;</span><span class="p">,</span></div><div class='line' id='LC46'>			<span class="s2">&quot;.&quot;</span><span class="o">:</span> <span class="s2">&quot;,&quot;</span><span class="p">,</span></div><div class='line' id='LC47'>			<span class="nx">symbol</span><span class="o">:</span> <span class="s2">&quot;Din.&quot;</span></div><div class='line' id='LC48'>		<span class="p">}</span></div><div class='line' id='LC49'>	<span class="p">},</span></div><div class='line' id='LC50'>	<span class="nx">calendars</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC51'>		<span class="nx">standard</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC52'>			<span class="s2">&quot;/&quot;</span><span class="o">:</span> <span class="s2">&quot;.&quot;</span><span class="p">,</span></div><div class='line' id='LC53'>			<span class="nx">firstDay</span><span class="o">:</span> <span class="mi">1</span><span class="p">,</span></div><div class='line' id='LC54'>			<span class="nx">days</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC55'>				<span class="nx">names</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;nedelja&quot;</span><span class="p">,</span><span class="s2">&quot;ponedeljak&quot;</span><span class="p">,</span><span class="s2">&quot;utorak&quot;</span><span class="p">,</span><span class="s2">&quot;sreda&quot;</span><span class="p">,</span><span class="s2">&quot;četvrtak&quot;</span><span class="p">,</span><span class="s2">&quot;petak&quot;</span><span class="p">,</span><span class="s2">&quot;subota&quot;</span><span class="p">],</span></div><div class='line' id='LC56'>				<span class="nx">namesAbbr</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;ned&quot;</span><span class="p">,</span><span class="s2">&quot;pon&quot;</span><span class="p">,</span><span class="s2">&quot;uto&quot;</span><span class="p">,</span><span class="s2">&quot;sre&quot;</span><span class="p">,</span><span class="s2">&quot;čet&quot;</span><span class="p">,</span><span class="s2">&quot;pet&quot;</span><span class="p">,</span><span class="s2">&quot;sub&quot;</span><span class="p">],</span></div><div class='line' id='LC57'>				<span class="nx">namesShort</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;ne&quot;</span><span class="p">,</span><span class="s2">&quot;po&quot;</span><span class="p">,</span><span class="s2">&quot;ut&quot;</span><span class="p">,</span><span class="s2">&quot;sr&quot;</span><span class="p">,</span><span class="s2">&quot;če&quot;</span><span class="p">,</span><span class="s2">&quot;pe&quot;</span><span class="p">,</span><span class="s2">&quot;su&quot;</span><span class="p">]</span></div><div class='line' id='LC58'>			<span class="p">},</span></div><div class='line' id='LC59'>			<span class="nx">months</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC60'>				<span class="nx">names</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;januar&quot;</span><span class="p">,</span><span class="s2">&quot;februar&quot;</span><span class="p">,</span><span class="s2">&quot;mart&quot;</span><span class="p">,</span><span class="s2">&quot;april&quot;</span><span class="p">,</span><span class="s2">&quot;maj&quot;</span><span class="p">,</span><span class="s2">&quot;jun&quot;</span><span class="p">,</span><span class="s2">&quot;jul&quot;</span><span class="p">,</span><span class="s2">&quot;avgust&quot;</span><span class="p">,</span><span class="s2">&quot;septembar&quot;</span><span class="p">,</span><span class="s2">&quot;oktobar&quot;</span><span class="p">,</span><span class="s2">&quot;novembar&quot;</span><span class="p">,</span><span class="s2">&quot;decembar&quot;</span><span class="p">,</span><span class="s2">&quot;&quot;</span><span class="p">],</span></div><div class='line' id='LC61'>				<span class="nx">namesAbbr</span><span class="o">:</span> <span class="p">[</span><span class="s2">&quot;jan&quot;</span><span class="p">,</span><span class="s2">&quot;feb&quot;</span><span class="p">,</span><span class="s2">&quot;mar&quot;</span><span class="p">,</span><span class="s2">&quot;apr&quot;</span><span class="p">,</span><span class="s2">&quot;maj&quot;</span><span class="p">,</span><span class="s2">&quot;jun&quot;</span><span class="p">,</span><span class="s2">&quot;jul&quot;</span><span class="p">,</span><span class="s2">&quot;avg&quot;</span><span class="p">,</span><span class="s2">&quot;sep&quot;</span><span class="p">,</span><span class="s2">&quot;okt&quot;</span><span class="p">,</span><span class="s2">&quot;nov&quot;</span><span class="p">,</span><span class="s2">&quot;dec&quot;</span><span class="p">,</span><span class="s2">&quot;&quot;</span><span class="p">]</span></div><div class='line' id='LC62'>			<span class="p">},</span></div><div class='line' id='LC63'>			<span class="nx">AM</span><span class="o">:</span> <span class="kc">null</span><span class="p">,</span></div><div class='line' id='LC64'>			<span class="nx">PM</span><span class="o">:</span> <span class="kc">null</span><span class="p">,</span></div><div class='line' id='LC65'>			<span class="nx">eras</span><span class="o">:</span> <span class="p">[{</span><span class="s2">&quot;name&quot;</span><span class="o">:</span><span class="s2">&quot;n.e.&quot;</span><span class="p">,</span><span class="s2">&quot;start&quot;</span><span class="o">:</span><span class="kc">null</span><span class="p">,</span><span class="s2">&quot;offset&quot;</span><span class="o">:</span><span class="mi">0</span><span class="p">}],</span></div><div class='line' id='LC66'>			<span class="nx">patterns</span><span class="o">:</span> <span class="p">{</span></div><div class='line' id='LC67'>				<span class="nx">d</span><span class="o">:</span> <span class="s2">&quot;d.M.yyyy&quot;</span><span class="p">,</span></div><div class='line' id='LC68'>				<span class="nx">D</span><span class="o">:</span> <span class="s2">&quot;d. MMMM yyyy&quot;</span><span class="p">,</span></div><div class='line' id='LC69'>				<span class="nx">t</span><span class="o">:</span> <span class="s2">&quot;H:mm&quot;</span><span class="p">,</span></div><div class='line' id='LC70'>				<span class="nx">T</span><span class="o">:</span> <span class="s2">&quot;H:mm:ss&quot;</span><span class="p">,</span></div><div class='line' id='LC71'>				<span class="nx">f</span><span class="o">:</span> <span class="s2">&quot;d. MMMM yyyy H:mm&quot;</span><span class="p">,</span></div><div class='line' id='LC72'>				<span class="nx">F</span><span class="o">:</span> <span class="s2">&quot;d. MMMM yyyy H:mm:ss&quot;</span><span class="p">,</span></div><div class='line' id='LC73'>				<span class="nx">M</span><span class="o">:</span> <span class="s2">&quot;d. MMMM&quot;</span><span class="p">,</span></div><div class='line' id='LC74'>				<span class="nx">Y</span><span class="o">:</span> <span class="s2">&quot;MMMM yyyy&quot;</span></div><div class='line' id='LC75'>			<span class="p">}</span></div><div class='line' id='LC76'>		<span class="p">}</span></div><div class='line' id='LC77'>	<span class="p">}</span></div><div class='line' id='LC78'><span class="p">});</span></div><div class='line' id='LC79'><br/></div><div class='line' id='LC80'><span class="p">}(</span> <span class="k">this</span> <span class="p">));</span></div></pre></div>
          </td>
        </tr>
      </table>
  </div>

          </div>
        </div>

        <a href="#jump-to-line" rel="facebox" data-hotkey="l" class="js-jump-to-line" style="display:none">Jump to Line</a>
        <div id="jump-to-line" style="display:none">
          <h2>Jump to Line</h2>
          <form accept-charset="UTF-8" class="js-jump-to-line-form">
            <input class="textfield js-jump-to-line-field" type="text">
            <div class="full-button">
              <button type="submit" class="button">Go</button>
            </div>
          </form>
        </div>

      </div>
    </div>
</div>

<div id="js-frame-loading-template" class="frame frame-loading large-loading-area" style="display:none;">
  <img class="js-frame-loading-spinner" src="https://a248.e.akamai.net/assets.github.com/images/spinners/octocat-spinner-128.gif?1347543527" height="64" width="64">
</div>


        </div>
      </div>
      <div class="modal-backdrop"></div>
    </div>

      <div id="footer-push"></div><!-- hack for sticky footer -->
    </div><!-- end of wrapper - hack for sticky footer -->

      <!-- footer -->
      <div id="footer">
  <div class="container clearfix">

      <dl class="footer_nav">
        <dt>GitHub</dt>
        <dd><a href="https://github.com/about">About us</a></dd>
        <dd><a href="https://github.com/blog">Blog</a></dd>
        <dd><a href="https://github.com/contact">Contact &amp; support</a></dd>
        <dd><a href="http://enterprise.github.com/">GitHub Enterprise</a></dd>
        <dd><a href="http://status.github.com/">Site status</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Applications</dt>
        <dd><a href="http://mac.github.com/">GitHub for Mac</a></dd>
        <dd><a href="http://windows.github.com/">GitHub for Windows</a></dd>
        <dd><a href="http://eclipse.github.com/">GitHub for Eclipse</a></dd>
        <dd><a href="http://mobile.github.com/">GitHub mobile apps</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Services</dt>
        <dd><a href="http://get.gaug.es/">Gauges: Web analytics</a></dd>
        <dd><a href="http://speakerdeck.com">Speaker Deck: Presentations</a></dd>
        <dd><a href="https://gist.github.com">Gist: Code snippets</a></dd>
        <dd><a href="http://jobs.github.com/">Job board</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Documentation</dt>
        <dd><a href="http://help.github.com/">GitHub Help</a></dd>
        <dd><a href="http://developer.github.com/">Developer API</a></dd>
        <dd><a href="http://github.github.com/github-flavored-markdown/">GitHub Flavored Markdown</a></dd>
        <dd><a href="http://pages.github.com/">GitHub Pages</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>More</dt>
        <dd><a href="http://training.github.com/">Training</a></dd>
        <dd><a href="https://github.com/edu">Students &amp; teachers</a></dd>
        <dd><a href="http://shop.github.com">The Shop</a></dd>
        <dd><a href="/plans">Plans &amp; pricing</a></dd>
        <dd><a href="http://octodex.github.com/">The Octodex</a></dd>
      </dl>

      <hr class="footer-divider">


    <p class="right">&copy; 2013 <span title="0.06994s from fe18.rs.github.com">GitHub</span>, Inc. All rights reserved.</p>
    <a class="left" href="https://github.com/">
      <span class="mega-icon mega-icon-invertocat"></span>
    </a>
    <ul id="legal">
        <li><a href="https://github.com/site/terms">Terms of Service</a></li>
        <li><a href="https://github.com/site/privacy">Privacy</a></li>
        <li><a href="https://github.com/security">Security</a></li>
    </ul>

  </div><!-- /.container -->

</div><!-- /.#footer -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-fullscreen-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="js-fullscreen-contents" placeholder="" data-suggester="fullscreen_suggester"></textarea>
          <div class="suggester-container">
              <div class="suggester fullscreen-suggester js-navigation-container" id="fullscreen_suggester"
                 data-url="/jquery/globalize/suggestions/commit">
              </div>
          </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped leftwards" title="Exit Zen Mode">
      <span class="mega-icon mega-icon-normalscreen"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped leftwards"
      title="Switch themes">
      <span class="mini-icon mini-icon-brightness"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="mini-icon mini-icon-exclamation"></span>
      Something went wrong with that request. Please try again.
      <a href="#" class="mini-icon mini-icon-remove-close ajax-error-dismiss"></a>
    </div>

    
    
    <span id='server_response_time' data-time='0.07040' data-host='fe18'></span>
    
  </body>
</html>

